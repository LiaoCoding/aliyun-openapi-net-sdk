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
using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.Ecs.Transform;
using Aliyun.Acs.Ecs.Transform.V20151101;
using System.Collections.Generic;

namespace Aliyun.Acs.Ecs.Model.V20151101
{
    public class StartRequest : RpcAcsRequest<StartResponse>
    {
        public StartRequest()
            : base("Ecs", "2015-11-01", "Start")
        {
        }

		private string instanceStartParam;

		public string InstanceStartParam
		{
			get
			{
				return instanceStartParam;
			}
			set	
			{
				instanceStartParam = value;
				DictionaryUtil.Add(QueryParameters, "InstanceStartParam", value);
			}
		}

        public override StartResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return StartResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}