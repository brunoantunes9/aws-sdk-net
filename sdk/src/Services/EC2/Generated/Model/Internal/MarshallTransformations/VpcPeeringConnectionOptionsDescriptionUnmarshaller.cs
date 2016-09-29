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
 * Do not modify this file. This file is generated from the ec2-2016-09-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.EC2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
namespace Amazon.EC2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for VpcPeeringConnectionOptionsDescription Object
    /// </summary>  
    public class VpcPeeringConnectionOptionsDescriptionUnmarshaller : IUnmarshaller<VpcPeeringConnectionOptionsDescription, XmlUnmarshallerContext>, IUnmarshaller<VpcPeeringConnectionOptionsDescription, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public VpcPeeringConnectionOptionsDescription Unmarshall(XmlUnmarshallerContext context)
        {
            VpcPeeringConnectionOptionsDescription unmarshalledObject = new VpcPeeringConnectionOptionsDescription();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.ReadAtDepth(originalDepth))
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("allowDnsResolutionFromRemoteVpc", targetDepth))
                    {
                        var unmarshaller = BoolUnmarshaller.Instance;
                        unmarshalledObject.AllowDnsResolutionFromRemoteVpc = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("allowEgressFromLocalClassicLinkToRemoteVpc", targetDepth))
                    {
                        var unmarshaller = BoolUnmarshaller.Instance;
                        unmarshalledObject.AllowEgressFromLocalClassicLinkToRemoteVpc = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("allowEgressFromLocalVpcToRemoteClassicLink", targetDepth))
                    {
                        var unmarshaller = BoolUnmarshaller.Instance;
                        unmarshalledObject.AllowEgressFromLocalVpcToRemoteClassicLink = unmarshaller.Unmarshall(context);
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return unmarshalledObject;
                }
            }

            return unmarshalledObject;
        }

        /// <summary>
        /// Unmarshaller error response to exception.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public VpcPeeringConnectionOptionsDescription Unmarshall(JsonUnmarshallerContext context)
        {
            return null;
        }


        private static VpcPeeringConnectionOptionsDescriptionUnmarshaller _instance = new VpcPeeringConnectionOptionsDescriptionUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static VpcPeeringConnectionOptionsDescriptionUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}