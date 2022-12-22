using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Smn.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class PublishAppMessageRequestBody 
    {

        /// <summary>
        ///  message与message_structure二者选其一。  message, App消息发布。  message_structure, 使用消息结构体方式的App消息发布。  app推送的消息内容，当前支持的推送平台有HMS、APNS、APNS_SANDBOX。  HMS是为开发者提供的消息推送平台。  APNS和APNS_SANDBOX是用于推送iOS消息的服务平台。  HMS平台指定的消息内容不超过2K。  APNS和APNS_SANDBOX平台的消息内容不能超过4K。  推送平台的消息内容格式要求详情见application消息体格式。  华为透传消息  {   \&quot;hps\&quot;: {     \&quot;msg\&quot;: {       \&quot;type\&quot;: 1,       \&quot;body\&quot;: {         \&quot;key\&quot;: \&quot;value\&quot;       }     }   } }  华为系统通知栏消息  {   \&quot;hps\&quot;: {     \&quot;msg\&quot;: {       \&quot;type\&quot;: 3,       \&quot;body\&quot;: {         \&quot;content\&quot;: \&quot;Push message content\&quot;,         \&quot;title\&quot;: \&quot;Push message content\&quot;       },       \&quot;action\&quot;: {         \&quot;type\&quot;: 1,         \&quot;param\&quot;: {           \&quot;intent\&quot;: \&quot;#Intent;compo&#x3D;com.rvr/.Activity;S.W&#x3D;U;end\&quot;         }       }     },     \&quot;ext\&quot;: {       \&quot;biTag\&quot;: \&quot;Trump\&quot;,       \&quot;icon\&quot;: \&quot;http://upload.w.org/00/150pxsvg.png\&quot;     }   } }  苹果平台消息格式 {   \&quot;aps\&quot;: {     \&quot;alert\&quot;: \&quot;hello world\&quot;   } }
        /// </summary>
        [JsonProperty("message", NullValueHandling = NullValueHandling.Ignore)]
        public string Message { get; set; }

        /// <summary>
        /// app推送的消息内容，当前支持的推送平台有HMS、APNS、APNS_SANDBOX。  HMS是为开发者提供的消息推送平台。  APNS和APNS_SANDBOX是用于推送iOS消息的服务平台。  HMS平台指定的消息内容不超过2K。  APNS和APNS_SANDBOX平台的消息内容不能超过4K。  推送平台的消息内容格式要求详情见application消息体格式。  华为透传消息  {   \&quot;HMS\&quot;: {     \&quot;hps\&quot;: {       \&quot;msg\&quot;: {         \&quot;type\&quot;: 1,         \&quot;body\&quot;: {           \&quot;key\&quot;: \&quot;value\&quot;         }       }     }   } }  华为系统通知栏消息  {   \&quot;HMS\&quot;: {     \&quot;hps\&quot;: {       \&quot;msg\&quot;: {         \&quot;type\&quot;: 3,         \&quot;body\&quot;: {           \&quot;content\&quot;: \&quot;Push message content\&quot;,           \&quot;title\&quot;: \&quot;Push message content\&quot;         },         \&quot;action\&quot;: {           \&quot;type\&quot;: 1,           \&quot;param\&quot;: {             \&quot;intent\&quot;: \&quot;#Intent;compo&#x3D;com.rvr/.Activity;S.W&#x3D;U;end\&quot;           }         }       },       \&quot;ext\&quot;: {         \&quot;biTag\&quot;: \&quot;Trump\&quot;,         \&quot;icon\&quot;: \&quot;http://upload.w.org/00/150pxsvg.png\&quot;       }     }   } }  苹果平台消息格式  {   \&quot;APNS\&quot;: {     \&quot;aps\&quot;: {       \&quot;alert\&quot;: \&quot;hello world\&quot;     }   } }
        /// </summary>
        [JsonProperty("message_structure", NullValueHandling = NullValueHandling.Ignore)]
        public string MessageStructure { get; set; }

        /// <summary>
        /// 消息发送的生存时间，是相对于发布时间的。  SMN系统将移动推送消息转交给推送平台前，会计算该消息在系统消耗的时间。只有消耗的时间小于time_to_live时，SMN才会将消息转交给推送平台，并将time_to_live减去消耗的时间传递给推送平台，否则消息废弃。  time _to_live的单位是s，变量默认值是3600s，即一小时。值为正整数且小于等于3600*24。
        /// </summary>
        [JsonProperty("time_to_live", NullValueHandling = NullValueHandling.Ignore)]
        public string TimeToLive { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PublishAppMessageRequestBody {\n");
            sb.Append("  message: ").Append(Message).Append("\n");
            sb.Append("  messageStructure: ").Append(MessageStructure).Append("\n");
            sb.Append("  timeToLive: ").Append(TimeToLive).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PublishAppMessageRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PublishAppMessageRequestBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Message == input.Message ||
                    (this.Message != null &&
                    this.Message.Equals(input.Message))
                ) && 
                (
                    this.MessageStructure == input.MessageStructure ||
                    (this.MessageStructure != null &&
                    this.MessageStructure.Equals(input.MessageStructure))
                ) && 
                (
                    this.TimeToLive == input.TimeToLive ||
                    (this.TimeToLive != null &&
                    this.TimeToLive.Equals(input.TimeToLive))
                );
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Message != null)
                    hashCode = hashCode * 59 + this.Message.GetHashCode();
                if (this.MessageStructure != null)
                    hashCode = hashCode * 59 + this.MessageStructure.GetHashCode();
                if (this.TimeToLive != null)
                    hashCode = hashCode * 59 + this.TimeToLive.GetHashCode();
                return hashCode;
            }
        }
    }
}
