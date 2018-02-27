using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresidentialEligibility_partA
{
    public class IndividualEligibility
    {
       private Boolean naturalBorn;
        private Int32 birthYear;
       private int yearsResidedUS;
       private  int priorTerms;
       private  Boolean rebelledAgainstUS;

        public IndividualEligibility()
        {
            naturalBorn = false;
            rebelledAgainstUS = false;
        }

        public void setPlaceBirth(Boolean naturalBorn)
        {
            this.naturalBorn = naturalBorn;
        }

        public void setBirthYear(Int32 birthYear)
        {
            if (birthYear.ToString().Length == 4 && birthYear < DateTime.Now.Year 
                && DateTime.Now.Year - birthYear <= 120 )
            {
                this.birthYear = birthYear;
            }

            else
            {
                throw new InvalidOperationException("Year was invalid.");
            }


       }

        public void setYearsResidedInUS(int  yearsResidedUS)
        {
            if (yearsResidedUS >=0 )
            {
                this.yearsResidedUS = yearsResidedUS;

            }

            else
            {
                throw new InvalidOperationException("Years entered must be a positive number.");
            }
        }

        public void setPriorTermsServed(int priorTerms)
        {
            if (priorTerms >=0)
            {
                this.priorTerms = priorTerms;
            }
            else
            {
                throw new InvalidOperationException("Number of prior terms must be greater than or equal to zero.");
            }

        }        
           
        public void setRebelledAgainstUS(Boolean rebelledAgainstUS)
        {
            this.rebelledAgainstUS = rebelledAgainstUS;
        }

        public Boolean determineEligibility()
        {
            if(naturalBorn == true)
            {
                if (DateTime.Now.Year - birthYear >= 35)
                {
                    if(yearsResidedUS >= 14)
                    {
                        if (priorTerms ==0 || priorTerms ==1)
                        {
                            if(rebelledAgainstUS==false)
                            {
                                return true;  // person has all the factors so is eligible to run for president. Otherwise, return false - can't run.
                            }
                            return false;
                        }
                        return false;
                    }
                    return false;
                }
                return false;
            }
            else
            {
                return false;
            }
        }



            }
}
