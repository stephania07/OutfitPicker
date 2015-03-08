using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OutfitPicker.Repository;
using OutfitPicker.Model;

namespace OutfitPickerTest
{
    [TestClass]
    public class OutfitRepositoryTest
    {
        private static OutfitRepository repo;

        [ClassInitialize]
        public static void SetUp(TestContext _context)
        {
            repo = new OutfitRepository();
            repo.Clear();
        }

        [ClassCleanup]
        public static void CleanUp()
        {
            repo.Clear();
            repo.Dispose();
        }

        [TestMethod]
        public void AddItem()
        {
            Assert.AreEqual(0, repo.GetCount());
            repo.Add(new Outfit("Wedding", "Zuria", "It should be long since it is for the bride."));
            Assert.AreEqual(1, repo.GetCount());
        }
    }
}
