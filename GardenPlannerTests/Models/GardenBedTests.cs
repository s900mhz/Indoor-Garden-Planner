using Microsoft.VisualStudio.TestTools.UnitTesting;
using GardenPlanner.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GardenPlanner.Models.Tests
{
    [TestClass()]
    public class GardenBedTests
    {
        GardenBed gardenBed = new GardenBed()
        {
            Length = 48,
            Width = 60,
        };
        Vegetable tomoato = new Vegetable()
        {
            SpaceBetween = 12
        };
        [TestInitialize]
        public void TestInitialize()
        {
        }

        [TestMethod()]
        public void HowManyPlantsInThisBedTest()
        {
            int result = gardenBed.HowManyPlantsInThisBed(tomoato);
            Assert.AreEqual(120, result);

        }
    }
}