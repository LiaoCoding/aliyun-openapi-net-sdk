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

namespace Aliyun.Acs.fnf.Model.V20190315
{
	public class ListExecutionsResponse : AcsResponse
	{

		private string requestId;

		private string nextToken;

		private List<ListExecutions_ExecutionsItem> executions;

		public string RequestId
		{
			get
			{
				return requestId;
			}
			set	
			{
				requestId = value;
			}
		}

		public string NextToken
		{
			get
			{
				return nextToken;
			}
			set	
			{
				nextToken = value;
			}
		}

		public List<ListExecutions_ExecutionsItem> Executions
		{
			get
			{
				return executions;
			}
			set	
			{
				executions = value;
			}
		}

		public class ListExecutions_ExecutionsItem
		{

			private string name;

			private string flowName;

			private string flowDefinition;

			private string input;

			private string output;

			private string status;

			private string startedTime;

			private string stoppedTime;

			private string externalInputUri;

			private string externalOutputUri;

			public string Name
			{
				get
				{
					return name;
				}
				set	
				{
					name = value;
				}
			}

			public string FlowName
			{
				get
				{
					return flowName;
				}
				set	
				{
					flowName = value;
				}
			}

			public string FlowDefinition
			{
				get
				{
					return flowDefinition;
				}
				set	
				{
					flowDefinition = value;
				}
			}

			public string Input
			{
				get
				{
					return input;
				}
				set	
				{
					input = value;
				}
			}

			public string Output
			{
				get
				{
					return output;
				}
				set	
				{
					output = value;
				}
			}

			public string Status
			{
				get
				{
					return status;
				}
				set	
				{
					status = value;
				}
			}

			public string StartedTime
			{
				get
				{
					return startedTime;
				}
				set	
				{
					startedTime = value;
				}
			}

			public string StoppedTime
			{
				get
				{
					return stoppedTime;
				}
				set	
				{
					stoppedTime = value;
				}
			}

			public string ExternalInputUri
			{
				get
				{
					return externalInputUri;
				}
				set	
				{
					externalInputUri = value;
				}
			}

			public string ExternalOutputUri
			{
				get
				{
					return externalOutputUri;
				}
				set	
				{
					externalOutputUri = value;
				}
			}
		}
	}
}
