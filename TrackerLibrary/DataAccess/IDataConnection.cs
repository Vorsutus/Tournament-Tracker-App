using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Models;

namespace TrackerLibrary.DataAccess
{
    public interface IDataConnection
    {
        /// <summary>
        /// Passing our model without an ID, and returning a PrizeModel that has an ID associated with it
        /// because it's been saved in either the text file, the DB or both.
        /// </summary>
        /// <param name="mode"></param>
        /// <returns></returns>
        PrizeModel CreatePrize(PrizeModel model);
    }
}
