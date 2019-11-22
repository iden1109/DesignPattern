/*
 * Copyright 2017 TeddySoft Technology. 
 * 
 */
using System;
using System.Runtime.CompilerServices;

namespace Tw.Teddysoft.Gof.Singleton.Ans
{
    public class AppConfig {
        private int timeout = 0;
        private int port = 0;
        private String workingDir = "";
        private static AppConfig instance = null;

        private AppConfig() {}

        [MethodImpl(MethodImplOptions.Synchronized)]
        public static AppConfig getInstance()
        {
            if (null == instance)
            {
                instance = new AppConfig();
            }
            return instance;
        }

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
