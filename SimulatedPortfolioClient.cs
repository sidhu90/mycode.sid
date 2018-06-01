using System;
using Apollo.Api.Domain.Entities;
using System.Collections.Generic;

namespace Apollo.Client
{
    public interface ISimulatedPortfolioClient
    {
        [Obsolete(Constants.ObsoleteMessage)]
        IList<SimPortfolioSetup> GetAllBySimType(string simType);
    }

    public class SimulatedPortfolioClient : ClientCache, ISimulatedPortfolioClient
    {
        public SimulatedPortfolioClient(IClientRequestor clientRequestor)
            : base("/SimulatedPortfolio/", clientRequestor)
        {
        }

        [Obsolete(Constants.ObsoleteMessage)]
        public IList<SimPortfolioSetup> GetAllBySimType(string simType)
        {
            return Get<IList<SimPortfolioSetup>>($"GetAll/{simType}");
        }
    }
}