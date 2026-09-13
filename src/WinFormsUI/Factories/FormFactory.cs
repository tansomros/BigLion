using System.Reflection;
using Microsoft.Extensions.DependencyInjection;
using SUTH.HealthCheckup.WinFormsUI.Interfaces;

namespace SUTH.HealthCheckup.WinFormsUI.Factories;
public class FormFactory : IFormFactory
{
    private readonly IServiceProvider _serviceProvider;

    public FormFactory(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public T Create<T>(params object[] parameters) where T : DevExpress.XtraEditors.XtraForm
    {
        try
        {
            var constructors = typeof(T).GetConstructors();
            foreach (var constructor in constructors) 
            {
                var constructorParams = constructor.GetParameters();
                if(CancelCreateWithConstructor(constructorParams, parameters))
                {
                    var allParams = BuildConstructorArguments(constructorParams, parameters);
                    return (T)Activator.CreateInstance(typeof(T), allParams);
                }
            }

            throw new InvalidOperationException($"No suitable constructor found for {typeof(T).Name}");
        }
        catch (TargetInvocationException ex) when (ex.InnerException != null)
        {
            System.Runtime.ExceptionServices.ExceptionDispatchInfo.Capture(ex.InnerException).Throw();
            throw; // Unreachable
        }
        catch (Exception ex) 
        {
            throw new InvalidOperationException($"Fail to create form {typeof(T).Name}: {ex.Message}", ex);
        }
    }

    private bool CancelCreateWithConstructor(ParameterInfo[] constructorParams, object[] parameters)
    {
        if (constructorParams.Length < parameters.Length)
        {
            return false;
        }

        for (int i = 0; i < parameters.Length; i++)
        {
            if (parameters[i] != null && !constructorParams[i].ParameterType.IsAssignableFrom(parameters[i].GetType()))
            { 
                return false;
            }
        }

        for (int i = parameters.Length; i < constructorParams.Length; i++)
        {
            if (_serviceProvider.GetRequiredService(constructorParams[i].ParameterType) == null)
            {
                return false;
            }
        }

        return true;
    }

    private object[] BuildConstructorArguments(ParameterInfo[] constructorParams, object[] parameters)
    {
        var allParams = new object[constructorParams.Length];
        for (int i = 0; i < parameters.Length; i++)
        {
            allParams[i] = parameters[i];
        }

        for(int i = parameters.Length; i < constructorParams.Length; i++)
        {
            allParams[i] = _serviceProvider.GetRequiredService(constructorParams[i].ParameterType);
        }

        return allParams;
    }
}
