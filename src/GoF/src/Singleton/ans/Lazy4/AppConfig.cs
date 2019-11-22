/*
 * Copyright 2017 TeddySoft Technology. 
 * 
 */
using System;
using System.Runtime.CompilerServices;

namespace Tw.Teddysoft.Gof.Singleton.Ans.Lazy4
{
    public class AppConfig {
        private static readonly Lazy<AppConfig> lazy =
            new Lazy<AppConfig>(() => new AppConfig());
        private AppConfig() {}
        public static AppConfig Instance {
            get { return lazy.Value; }
        }

        private int timeout = 0;
        private int port = 0;
        private String workingDir = "";


        public int getTimeout()
        {
            return timeout;
        }

        public void setTimeout(int timeout)
        {
            this.timeout = timeout;
        }

        public int getPort()
        {
            return port;
        }

        public void setPort(int port)
        {
            this.port = port;
        }

        public String getWorkingDir()
        {
            return workingDir;
        }

        public void setWorkingDir(String workingDir)
        {
            this.workingDir = workingDir;
        }
    }

}
