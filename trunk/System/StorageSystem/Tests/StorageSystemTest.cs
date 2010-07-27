﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using CrawlerNameSpace.Utilities;

namespace CrawlerNameSpace.StorageSystem
{
    /**
     * This class contains the main class from which all the tests of the project StorageSystem
     * will be tested.
     */

    class StorageSystemTest
    {
        
        public static void MainTest()
        {
            try
            {
                ConfigurationStorageTest test = new ConfigurationStorageTest();
                //test.Test1();
                //test.Test2();
               // test.Test3();
                //test.Test4();

                CategoriesStorageTest catTest = new CategoriesStorageTest();
                //catTest.Test3();

                SettingsStorageTest setTest = new SettingsStorageTest();
                //setTest.Test4();

                ResultStorageTest resultTest = new ResultStorageTest();
                //resultTest.Test1();
                resultTest.Test2();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception Caught " + e.Message);
            }
        }
        
    }
}
