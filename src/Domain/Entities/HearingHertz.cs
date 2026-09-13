using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigLion.Domain.Entities;
public class HearingHertz : BaseEntity
{
    /// <summary>
    /// ค่าความถี่
    /// </summary>
    public int Hertz { get; set; }
    public HearingHertz( int hertz)
    {
        Hertz = hertz;
    }
}

