/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the iotsitewise-2019-12-02.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.IoTSiteWise.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.IoTSiteWise.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for DescribeDashboard operation
    /// </summary>  
    public class DescribeDashboardResponseUnmarshaller : JsonResponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
        {
            DescribeDashboardResponse response = new DescribeDashboardResponse();

            context.Read();
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("dashboardArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.DashboardArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("dashboardCreationDate", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    response.DashboardCreationDate = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("dashboardDefinition", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.DashboardDefinition = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("dashboardDescription", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.DashboardDescription = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("dashboardId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.DashboardId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("dashboardLastUpdateDate", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    response.DashboardLastUpdateDate = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("dashboardName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.DashboardName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("projectId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.ProjectId = unmarshaller.Unmarshall(context);
                    continue;
                }
            }

            return response;
        }

        /// <summary>
        /// Unmarshaller error response to exception.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="innerException"></param>
        /// <param name="statusCode"></param>
        /// <returns></returns>
        public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
        {
            ErrorResponse errorResponse = JsonErrorResponseUnmarshaller.GetInstance().Unmarshall(context);
            if (errorResponse.Code != null && errorResponse.Code.Equals("InternalFailureException"))
            {
                return new InternalFailureException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
            }
            if (errorResponse.Code != null && errorResponse.Code.Equals("InvalidRequestException"))
            {
                return new InvalidRequestException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
            }
            if (errorResponse.Code != null && errorResponse.Code.Equals("ResourceNotFoundException"))
            {
                return new ResourceNotFoundException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
            }
            if (errorResponse.Code != null && errorResponse.Code.Equals("ThrottlingException"))
            {
                return new ThrottlingException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
            }
            return new AmazonIoTSiteWiseException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
        }

        private static DescribeDashboardResponseUnmarshaller _instance = new DescribeDashboardResponseUnmarshaller();        

        internal static DescribeDashboardResponseUnmarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DescribeDashboardResponseUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}