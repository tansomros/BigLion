param(
    [string]$FilePath
)

if (-not (Test-Path $FilePath)) {
    Write-Host "File not found: $FilePath"
    exit 0
}

Write-Host "Processing: $FilePath"

$content = Get-Content $FilePath -Raw -Encoding UTF8

$pattern = '(?s)internal class DateFormatConverter\s*:\s*Newtonsoft\.Json\.Converters\.IsoDateTimeConverter\s*\{\s*public DateFormatConverter\(\)\s*\{\s*DateTimeFormat\s*=\s*"[^"]*";\s*\}\s*\}'

$replacement = 'internal class DateFormatConverter : Newtonsoft.Json.JsonConverter
    {
        public override bool CanConvert(System.Type objectType)
        {
            return objectType == typeof(System.DateTime) || objectType == typeof(System.DateTime?) || objectType == typeof(System.DateTimeOffset) || objectType == typeof(System.DateTimeOffset?);
        }

        public override object ReadJson(Newtonsoft.Json.JsonReader reader, System.Type objectType, object existingValue, Newtonsoft.Json.JsonSerializer serializer)
        {
            if (reader.Value == null) return null;
            var dateString = reader.Value.ToString();
            if (objectType == typeof(System.DateTimeOffset) || objectType == typeof(System.DateTimeOffset?))
                return System.DateTimeOffset.Parse(dateString, System.Globalization.CultureInfo.InvariantCulture);
            return System.DateTime.Parse(dateString, System.Globalization.CultureInfo.InvariantCulture);
        }

        public override void WriteJson(Newtonsoft.Json.JsonWriter writer, object value, Newtonsoft.Json.JsonSerializer serializer)
        {
            if (value is System.DateTime dt)
                writer.WriteValue(dt.ToString("yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture));
            else if (value is System.DateTimeOffset dto)
                writer.WriteValue(dto.ToString("yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture));
            else
                writer.WriteNull();
        }
    }'

if ($content -match 'IsoDateTimeConverter') {
    $newContent = [regex]::Replace($content, $pattern, $replacement)
    [System.IO.File]::WriteAllText($FilePath, $newContent)
    Write-Host "Done: DateFormatConverter replaced"
} else {
    Write-Host "Skip: IsoDateTimeConverter not found"
}

exit 0