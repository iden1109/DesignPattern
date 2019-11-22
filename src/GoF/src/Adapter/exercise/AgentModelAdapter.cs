/*
 * Copyright 2017 TeddySoft Technology. 
 * 
 */
using System;
using System.Collections.Generic;

namespace Tw.Teddysoft.Gof.Adapter.Exercise
{
    internal class AgentModelAdapter
    {
        private ConfigContext _configContext;
        private Agent _agent;
        private IList<Acceptor> _acceptorList = new List<Acceptor>();
        public AgentModelAdapter(ConfigContext configContext)
        {
            this._configContext = configContext;
        }

        internal void addAcceport(Acceptor acceptor)
        {
            _acceptorList.Add(acceptor);
        }

        internal IList<Acceptor> getAcceptors()
        {
            return _acceptorList;
        }

        internal void setAgent(Agent agent)
        {
            this._agent = agent;
        }

        internal Agent getAgent()
        {
            return this._agent;
        }
    }
}