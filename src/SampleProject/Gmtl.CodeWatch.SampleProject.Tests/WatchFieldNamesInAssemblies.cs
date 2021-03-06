﻿using NUnit.Framework;

namespace Gmtl.CodeWatch.SampleProject.Tests
{
    [TestFixture]
    public class WatchFieldNamesInAssemblies
    {
        [Test]
        public void AllPropertiesInAssemblyMustStartWithUppercase()
        {
            FieldNamingWatcher fieldNamingWatcher = new FieldNamingWatcher();
            fieldNamingWatcher.Configure(Naming.UpperCase);
            fieldNamingWatcher.WatchAssembly(typeof(DomainModel).Assembly);

            fieldNamingWatcher.Execute();
        }
    }
}