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
using Aliyun.Acs.gpdb.Transform;
using Aliyun.Acs.gpdb.Transform.V20160503;

namespace Aliyun.Acs.gpdb.Model.V20160503
{
    public class ModifySecurityIpsRequest : RpcAcsRequest<ModifySecurityIpsResponse>
    {
        public ModifySecurityIpsRequest()
            : base("gpdb", "2016-05-03", "ModifySecurityIps", "gpdb", "openAPI")
        {
        }

		private string securityIPList;

		private string dBInstanceIPArrayName;

		private string dBInstanceIPArrayAttribute;

		private string dBInstanceId;

		private string accessKeyId;

		public string SecurityIPList
		{
			get
			{
				return securityIPList;
			}
			set	
			{
				securityIPList = value;
				DictionaryUtil.Add(QueryParameters, "SecurityIPList", value);
			}
		}

		public string DBInstanceIPArrayName
		{
			get
			{
				return dBInstanceIPArrayName;
			}
			set	
			{
				dBInstanceIPArrayName = value;
				DictionaryUtil.Add(QueryParameters, "DBInstanceIPArrayName", value);
			}
		}

		public string DBInstanceIPArrayAttribute
		{
			get
			{
				return dBInstanceIPArrayAttribute;
			}
			set	
			{
				dBInstanceIPArrayAttribute = value;
				DictionaryUtil.Add(QueryParameters, "DBInstanceIPArrayAttribute", value);
			}
		}

		public string DBInstanceId
		{
			get
			{
				return dBInstanceId;
			}
			set	
			{
				dBInstanceId = value;
				DictionaryUtil.Add(QueryParameters, "DBInstanceId", value);
			}
		}

		public string AccessKeyId
		{
			get
			{
				return accessKeyId;
			}
			set	
			{
				accessKeyId = value;
				DictionaryUtil.Add(QueryParameters, "AccessKeyId", value);
			}
		}

        public override ModifySecurityIpsResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ModifySecurityIpsResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
