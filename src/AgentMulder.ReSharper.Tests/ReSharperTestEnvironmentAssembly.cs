﻿﻿using System.Threading;
 using JetBrains.Application.BuildScript.Application.Zones;
﻿using JetBrains.ReSharper.TestFramework;
﻿using JetBrains.TestFramework;
﻿using JetBrains.TestFramework.Application.Zones;
﻿using NUnit.Framework;


[assembly: Apartment(ApartmentState.STA)]

/// <summary>
/// Test environment. Must be in the global namespace.
/// </summary>
// ReSharper disable CheckNamespace
[ZoneDefinition]
// ReSharper disable once CheckNamespace
public class TestEnvironmentZone : ITestsEnvZone, IRequire<PsiFeatureTestZone>
{ 
}

[SetUpFixture]
public class ReSharperTestEnvironmentAssembly : ExtensionTestEnvironmentAssembly<TestEnvironmentZone>
{

}