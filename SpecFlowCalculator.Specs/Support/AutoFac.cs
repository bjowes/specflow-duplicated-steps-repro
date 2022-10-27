
using Autofac;
using SpecFlow.Autofac;
using SpecFlow.Autofac.SpecFlowPlugin;
using SpecFlowCalculator.Specs.API;
using SpecFlowCalculator.Specs.Steps;
using System;

namespace SpecFlowCalculator.Specs.Support
{
    public static class AutoFacInit
    {
          
        [GlobalDependencies]
        public static void CreateGlobalContainer(ContainerBuilder containerBuilder)
        {
            Console.WriteLine("CreateGlobalContainer");
            containerBuilder.RegisterType<CalculatorApi>();
        }
          
        
        [ScenarioDependencies]
        public static void CreateContainerBuilder(ContainerBuilder containerBuilder)
        {
            // Register scenario scoped runtime dependencies
            Console.WriteLine("CreateContainerBuilder");

            containerBuilder.AddSpecFlowBindings<CalculatorStepDefinitions>();
        }
    }
}
