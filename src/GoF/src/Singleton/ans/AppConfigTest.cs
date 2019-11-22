/*
 * Copyright 2017 TeddySoft Technology. 
 * 
 */
using System;
using NUnit.Framework;

namespace Tw.Teddysoft.Gof.Singleton.Ans
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

	    /// <summary>
        /// 
        /// </summary>
        [Test]
        public void cannot_call_the_default_constructor() 
        {
            try {
                AppConfig instance = (AppConfig) Activator.CreateInstance(typeof(AppConfig));
                Assert.Fail();
            }
            catch(MissingMethodException e){
                Console.WriteLine(e.Message);
                Assert.AreEqual("這個物件沒有定義無參數的建構函式。",e.Message);
            }
		}
    }
}
