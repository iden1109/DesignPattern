/*
 * Copyright 2017 TeddySoft Technology. 
 * 
 */
using System;

namespace Tw.Teddysoft.Gof.Strategy.Ans
{
    public class DriveManager
    {
        public void format(String fileSystem)
        {
            createFormater(fileSystem).execute();
        }
        private Formater createFormater(String fileSystem)
        {
            String fullyQualifiedName = "Tw.Teddysoft.Gof.Strategy.Ans." + fileSystem;
            try
            {
                Type formater = Type.GetType(fullyQualifiedName);
                return (Formater) Activator.CreateInstance(formater);
            }
            catch (Exception e)
            {
                throw new Exception("Cannot create formater.", e);
            }
        }
    }
}
