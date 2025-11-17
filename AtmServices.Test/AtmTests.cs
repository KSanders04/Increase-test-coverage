namespace AtmServices.Test;

using AtmServices;

public class AtmTests {

    Atm testAtm;

    int initialBalance = 100;

    public AtmTests() {

        testAtm = new Atm(initialBalance);

    }

    [Fact]
    public void Test_Withdraw(){

        var result = testAtm.withdraw(25);

        Assert.True(result);

        Assert.Equal(75, testAtm.getBalance());

        Assert.False (testAtm.withdraw(200));

    }

    [Fact]
    public void Test_deposit(){

        var result = testAtm.deposit(50);

        Assert.True(result);

        Assert.Equal(150, testAtm.getBalance());

        Assert.False(testAtm.deposit(-20));

    }
}