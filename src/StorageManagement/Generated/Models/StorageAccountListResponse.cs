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
using Microsoft.WindowsAzure;
using Microsoft.WindowsAzure.Management.Storage.Models;

namespace Microsoft.WindowsAzure.Management.Storage.Models
{
    /// <summary>
    /// The List Storage Accounts operation response.
    /// </summary>
    public partial class StorageAccountListResponse : OperationResponse, IEnumerable<StorageAccount>
    {
        private IList<StorageAccount> _storageAccounts;
        
        /// <summary>
        /// Optional. The requested storage accounts.
        /// </summary>
        public IList<StorageAccount> StorageAccounts
        {
            get { return this._storageAccounts; }
            set { this._storageAccounts = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the StorageAccountListResponse class.
        /// </summary>
        public StorageAccountListResponse()
        {
            this.StorageAccounts = new List<StorageAccount>();
        }
        
        /// <summary>
        /// Gets the sequence of StorageAccounts.
        /// </summary>
        public IEnumerator<StorageAccount> GetEnumerator()
        {
            return this.StorageAccounts.GetEnumerator();
        }
        
        /// <summary>
        /// Gets the sequence of StorageAccounts.
        /// </summary>
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
