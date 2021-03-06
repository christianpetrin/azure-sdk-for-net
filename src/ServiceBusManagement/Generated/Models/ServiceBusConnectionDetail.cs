// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.WindowsAzure.Management.ServiceBus.Models;

namespace Microsoft.WindowsAzure.Management.ServiceBus.Models
{
    /// <summary>
    /// A connection string for a service bus entity.
    /// </summary>
    public partial class ServiceBusConnectionDetail
    {
        private string _authorizationType;
        
        /// <summary>
        /// Optional. The type of authorization for the connection to the
        /// entity.
        /// </summary>
        public string AuthorizationType
        {
            get { return this._authorizationType; }
            set { this._authorizationType = value; }
        }
        
        private string _connectionString;
        
        /// <summary>
        /// Optional. The connection string to the entity.
        /// </summary>
        public string ConnectionString
        {
            get { return this._connectionString; }
            set { this._connectionString = value; }
        }
        
        private string _keyName;
        
        /// <summary>
        /// Optional. The name of the key used in the connection.
        /// </summary>
        public string KeyName
        {
            get { return this._keyName; }
            set { this._keyName = value; }
        }
        
        private IList<AccessRight> _rights;
        
        /// <summary>
        /// Optional. The rights connections to the entity via the connection
        /// string will have.
        /// </summary>
        public IList<AccessRight> Rights
        {
            get { return this._rights; }
            set { this._rights = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the ServiceBusConnectionDetail class.
        /// </summary>
        public ServiceBusConnectionDetail()
        {
            this.Rights = new List<AccessRight>();
        }
    }
}
