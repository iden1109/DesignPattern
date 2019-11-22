/*
 * Copyright 2017 TeddySoft Technology. 
 * 
 */
using System;
using NUnit.Framework;

namespace Tw.Teddysoft.Gof.Singleton.Exercise
{
    [TestFixture]
    public class AppConfigTest
    {

        [Test]
        public void default_instance_is_not_null()
        {
            AppConfig config = AppConfig.getInstance();
            Assert.NotNull(config);
        }

        [Test]
        public void call_getInstance_twice_get_the_smae_instance()
        {
            Assert.AreEqual(AppConfig.getInstance(), AppConfig.getInstance());
        }

        [Test]
        public void cannot_call_the_default_constructor()
        {
            try
            {
                AppConfig instance = (AppConfig)Activator.CreateInstance(typeof(AppConfig));
                Assert.Fail();
            }
            catch (MissingMethodException e)
            {
                Console.WriteLine(e.Message);
                Assert.AreEqual("No parameterless constructor defined for this object.", e.Message);
            }
        }
    }
}
