// See https://aka.ms/new-console-template for more information

using FirstConsoleApp;

Console.WriteLine("-  - - ---> Hello! Welcome to FirstConsoleApp version 0.0.4 <--- - -  -");

static void printInfo(string? employeeFN, string? employeeLN, int incomeTaxSum, int socialInsuranceSum, int additionalMedicalInsuranceSum, int pensionFundSum, int charityFeesSum, int totalFees, int salaryNetto)
{
    System.Console.WriteLine(employeeFN + " " + employeeLN + " ");
    System.Console.WriteLine("incomeTax: " + incomeTaxSum);
    System.Console.WriteLine("socialInsurance: " + socialInsuranceSum);
    System.Console.WriteLine("sadditionalMedicalInsurance: " + additionalMedicalInsuranceSum);
    System.Console.WriteLine("pensionFund: " + pensionFundSum);
    System.Console.WriteLine("charityFees: " + charityFeesSum);
    System.Console.WriteLine("totalFees: " + totalFees);
    System.Console.WriteLine("salaryNetto: " + salaryNetto);
}

static int getSocialInsurance(int income)
{
    int socialInsurance;
    if (income < 2000)
    {
        socialInsurance = 5;
    }
    else if (income >= 2000 && income < 5000)
    {
        socialInsurance = 10;
    }
    else
    {
        socialInsurance = 35;
    }

    return socialInsurance;
}

static int sumAllFees(int incomeTaxSum, int socialInsuranceSum, int additionalMedicalInsuranceSum, int pensionFundSum, int charityFeesSum)
{
    return incomeTaxSum + socialInsuranceSum + additionalMedicalInsuranceSum + pensionFundSum + charityFeesSum;
}

String? employeeFNLN;

Console.WriteLine("Enter employee's first & last name: ");



for (int i = 0; i < 3; i = i++)
{

    // FIXME: Check value for empty strins
    employeeFNLN = Console.ReadLine();
    // TODO: Check empty first name and empty last name
    string[] fnlnArr = employeeFNLN!.Split(" ");

    Console.WriteLine("Enter income: ");
    int startIncome = Convert.ToInt32(Console.ReadLine());

    Employee epl = new Employee(fnlnArr[0], fnlnArr[1], 7, 10);


    int income = epl.getIncomeSum(startIncome);
    if (income == -1) {
     Console.WriteLine("ERROR INCOME!!!!");
     continue;
   }

    int incomeTax;
    int socialInsurance;
    int additionalMedicalInsurance;
    int pensionFund;
    int charityFees;

    incomeTax = 5;

    additionalMedicalInsurance = 10;
    pensionFund = 5;
    charityFees = 1;
    socialInsurance = getSocialInsurance(income);

    int incomeTaxSum = income / 100 * incomeTax;
    int socialInsuranceSum = income / 100 * socialInsurance;
    int additionalMedicalInsuranceSum = income / 100 * additionalMedicalInsurance;
    int pensionFundSum = income / 100 * pensionFund;
    int charityFeesSum = income / 100 * charityFees;
    int totalFees = sumAllFees(incomeTaxSum, socialInsuranceSum,
                                additionalMedicalInsuranceSum,
                                pensionFundSum, charityFeesSum);

    int salaryNetto = income - totalFees;
    printInfo(epl.firstName, epl.lastName, incomeTaxSum, socialInsuranceSum, additionalMedicalInsuranceSum, pensionFundSum, charityFeesSum, totalFees, salaryNetto);

}
