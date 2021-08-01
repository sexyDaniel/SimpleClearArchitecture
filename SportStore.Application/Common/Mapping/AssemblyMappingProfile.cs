using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace SportStore.Application.Common.Mapping
{
    public class AssemblyMappingProfile:Profile
    {
        public AssemblyMappingProfile(Assembly assembly) => AssemblyMapping(assembly);

        private void AssemblyMapping(Assembly assembly) 
        {
            var types = assembly.GetExportedTypes()
                .Where(t => t.GetInterfaces()
                    .Any(i => i.IsGenericType && i.GetGenericTypeDefinition() == typeof(IMapWith<>)))
                .ToList();

            foreach (var t in types) 
            {
                var instance = Activator.CreateInstance(t);
                var method = t.GetMethod("Mapping");
                method?.Invoke(instance, new object[] { this });
            }
        }
    }
}
