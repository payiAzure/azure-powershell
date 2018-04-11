// ----------------------------------------------------------------------------------
//
// Copyright Microsoft Corporation
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// ----------------------------------------------------------------------------------

using SqlDatabaseModel = Microsoft.Azure.Commands.Sql.Database.Model;
using Microsoft.Azure.Management.Sql.Models;
using System;
using System.Collections.Generic;

namespace Microsoft.Azure.Commands.Sql.ElasticPool.Model
{
    /// <summary>
    /// Represents an Azure Sql Elastic Pool
    /// </summary>
    public class AzureSqlElasticPoolModel
    {
        /// <summary>
        /// Gets or sets the resource id for this resource
        /// </summary>
        public string ResourceId { get; set; }

        /// <summary>
        /// Gets or sets the name of the resource group
        /// </summary>
        public string ResourceGroupName { get; set; }

        /// <summary>
        /// Gets or sets the name of the server
        /// </summary>
        public string ServerName { get; set; }

        /// <summary>
        /// Gets or sets the name of the elastic pool
        /// </summary>
        public string ElasticPoolName { get; set; }

        /// <summary>
        /// Gets or sets the location for the Elastic Pool.  Must be the same as server location
        /// </summary>
        public string Location { get; set; }

        /// <summary>
        /// Gets or sets the creation date of the elastic pool
        /// </summary>
        public DateTime CreationDate { get; set; }

        /// <summary>
        /// Gets or sets the state of the elastic pool
        /// </summary>
        public string State { get; set; }

        /// <summary>
        /// Gets or sets the edition of the elastic pool
        /// </summary>
        public SqlDatabaseModel.DatabaseEdition? Edition { get; set; }

        /// <summary>
        /// Gets or sets the Compute generation name of the elastic pool
        /// </summary>
        public string ComputeGeneration { get; set; }

        /// <summary>
        /// Gets or sets the Sku capacity of the elastic pool
        /// </summary>
        public int? Capacity { get; set; }

        /// <summary>
        /// Gets or sets the Minumum capacity of the elastic pool
        ///    For Dtu pool, it is the min Database Dtu of the pool; for Vcore pool, it is the min vcore capacity of the pool
        /// </summary>
        public double? MinCapacity { get; set; }

        /// <summary>
        /// Gets or sets the Maximum capacity of the elastic pool
        ///    For Dtu pool, it is the max Database Dtu of the pool; for Vcore pool, it is the max vcore capacity of the pool
        /// </summary>
        public double? MaxCapacity { get; set; }

        /// <summary>
        /// Gets or sets the amount of storage in bytes the elastic pool has in bytes
        /// </summary>
        public long? MaxSizeBytes { get; set; }

        /// <summary>
        /// Gets or sets the tags associated with the Elastic Pool.
        /// </summary>
        public Dictionary<string, string> Tags { get; set; }

        /// <summary>
        /// Gets or sets the zone redundant option of the elastic pool.
        /// </summary>
        public bool? ZoneRedundant { get; set; }

        /// <summary>
        /// Gets or sets the Sku of the elastic pool.
        /// </summary>
        public Sku Sku { get; set; }

        /// <summary>
        /// Gets or sets the per database settings of the elastic pool.
        /// </summary>
        public ElasticPoolPerDatabaseSettings PerDatabaseSettings { get; set; }

        /// <summary>
        /// Gets or sets the kind of the elastic pool. This is metadata used for the Azure
        /// portal experience.
        /// </summary>
        public string Kind { get; set; }

        /// <summary>
        /// Gets or sets the license type to apply for this elastic pool.
        /// Possible values include: 'LicenseIncluded', 'BasePrice'
        /// </summary>
        public string LicenseType { get; set; }
    }
}
