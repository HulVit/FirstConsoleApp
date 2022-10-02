using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstConsoleApp
{
    public class Employee
    {
        public string firstName;
        public string lastName;
        int experienceYears;
        int numberOfPassedExams;
        
        public Employee(string fn, string ln, int eY, int nopex) {
            this.firstName = fn;
            this.lastName = ln;
            this.experienceYears = eY;
            this.numberOfPassedExams = nopex;
        }
        
        public int getIncomeSum(int startIncome) {
            int resultIncome = 0;
            if (startIncome <= 0) {
                //resultIncome = -1;
                Console.WriteLine("ERROR");
                return -1;
            }
            else{
                if (this.experienceYears <= 0){
                    Console.WriteLine("ERROR");
                    return -1;
                }
                else{
                    resultIncome = startIncome + startIncome / 100 * 10;
                }

                if (this.numberOfPassedExams <= 0){
                    Console.WriteLine("ERROR");
                    return -1;
                }
                else{
                    resultIncome = resultIncome + resultIncome / 100 * 15;
                }

            }
            return resultIncome;
        }
    }
}