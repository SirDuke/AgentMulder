﻿// Patterns: 1
// Matches: Foo.cs
// NotMatches: Baz.cs

using Microsoft.Extensions.DependencyInjection;
using TestApplication.Types;

namespace TestApplication.AspNetCore
{
    public class AddScopedDoubleTypeOf
    {
        public AddScopedDoubleTypeOf()
        {
            var container = new ServiceCollection();
            container.AddScoped(typeof(IFoo), typeof(Foo));
        }
    }
}