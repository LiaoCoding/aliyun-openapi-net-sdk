/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */
using System.Collections.Generic;

using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.Config.Transform;
using Aliyun.Acs.Config.Transform.V20190108;

namespace Aliyun.Acs.Config.Model.V20190108
{
    public class ActiveConfigRulesRequest : RpcAcsRequest<ActiveConfigRulesResponse>
    {
        public ActiveConfigRulesRequest()
            : base("Config", "2019-01-08", "ActiveConfigRules", "Config", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Config.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Config.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string configRuleIds;

		public string ConfigRuleIds
		{
			get
			{
				return configRuleIds;
			}
			set	
			{
				configRuleIds = value;
				DictionaryUtil.Add(QueryParameters, "ConfigRuleIds", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override ActiveConfigRulesResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ActiveConfigRulesResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
