﻿
//
// Licensed to Green Energy Corp (www.greenenergycorp.com) under one or
// more contributor license agreements. See the NOTICE file distributed
// with this work for additional information regarding copyright ownership.
// Green Energy Corp licenses this file to you under the Apache License,
// Version 2.0 (the "License"); you may not use this file except in
// compliance with the License.  You may obtain a copy of the License at
//
// http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//
// This file was forked on 01/01/2013 by Automatak, LLC and modifications
// have been made to this file. Automatak, LLC licenses these modifications to
// you under the terms of the License.
//
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNP3.Interface
{    
    /// <summary>
    /// A communication channel to which DNP3 masters / outstation can be attached
    /// </summary>
    public interface IChannel
    {      
        /// <summary>
        /// Adds a master stack to the channel
        /// </summary>
        /// <param name="loggerId">name of the logger that will be assigned to this stack</param>
        /// <param name="level">LogLevel assigned to the logger</param>
        /// <param name="publisher">Where measurements will be sent as they are received from the outstation</param>
        /// <param name="config">configuration information for the master stack</param>
        /// <returns>reference to the created master</returns>
		IMaster AddMaster(String loggerId, LogLevel level, IDataObserver publisher, MasterStackConfig config);

        /// <summary>
        /// Adds an outstation to the channel
        /// </summary>
        /// <param name="loggerId">name of the logger that will be assigned to this stack</param>
        /// <param name="level">LogLevel assigned to the logger</param>
        /// <param name="cmdHandler">where command requests are sent to be handled in application code</param>
        /// <param name="config">configuration information for the outstation stack</param>
        /// <returns>reference to the created master</returns>
		IOutstation AddOutstation(String loggerId, LogLevel level, ICommandHandler cmdHandler, SlaveStackConfig config);

        /// <summary>
        /// Add a listener for changes to the channel state. All callbacks come from the thread pool.
		/// An immediate callback will be made with the current state.		
        /// </summary>
        /// <param name="listener">Action to callback with the state enumeration </param>
        void AddStateListener(Action<ChannelState> listener);

        /// <summary>
        /// Shutdown the channel and all stacks that have been added. Calling shutdown more than once or
        /// continuing to use child objects (masters/outstations) after calling shutdown can cause a failure.     
        /// </summary>
        void Shutdown();
    }
}
