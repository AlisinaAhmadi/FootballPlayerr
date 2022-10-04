using FootballPlayerr;

namespace FootballPlayerTEST
 
   


{
    [TestClass ]
    public class footballplayertest
    {


        FootballPlayer footballPlayer = new FootballPlayer { Id = 1, Name = "Ali", age = 22, ShirtNumber = 10 };
        //FootballPlayer footballPlayerNameToshort = new FootballPlayer { Id = 2, Name = "2", age = 22, ShirtNumber = 9 };
        //FootballPlayer footballPlayerageToHigh = new FootballPlayer { Id = 3, Name = "", age = 26, ShirtNumber = 25 };
        //FootballPlayer footballPlayerShirtNumberTolowe = new FootballPlayer { Id = 3, Name = "", age = 25, ShirtNumber = 100 };

        [TestMethod]
        public void TestNameExecption()
        {
            //arrange
            FootballPlayer footballPlayer = new FootballPlayer { Id = 1, Name = "A", age = 22, ShirtNumber = 10 };

            //act
            footballPlayer.Validate();

            //Assert
            Assert.AreEqual(footballPlayer.Name.Length > 2, "A".Length > 2);

        }
        [TestMethod]
        public void TestageExcption()
        {   //arrange
            FootballPlayer footballPlaye = new FootballPlayer { Id = 1, Name = "A", age = 6, ShirtNumber = 10 };

            //act
            footballPlayer.Validateage();
            //assert
            Assert.AreEqual(footballPlayer.age > 1 && footballPlayer.age < 120, 2 > 1 && 2 < 120);

        }


    }
}