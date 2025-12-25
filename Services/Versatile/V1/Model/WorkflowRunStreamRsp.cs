using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Versatile.V1.Model
{
    /// <summary>
    /// 工作流执行接口流式响应体
    /// </summary>
    public class WorkflowRunStreamRsp 
    {

        /// <summary>
        /// 事件类型：1、workflow_started 2、node_started 3、node_wait 4、node_finished 5、workflow_finished 6、text_chunk ：流式输出到对话框的信息
        /// </summary>
        [JsonProperty("event", NullValueHandling = NullValueHandling.Ignore)]
        public string Event { get; set; }

        /// <summary>
        /// 执行的conversation_id
        /// </summary>
        [JsonProperty("conversation_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ConversationId { get; set; }

        /// <summary>
        /// 类型说明：1. node_started，node_finished，node_wait data使用NodeInfo对象 2. workflow_started, workflow_finished  data使用 WorkflowInfo对象 3. text_chunk使用对象TextChunk
        /// </summary>
        [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
        public Object Data { get; set; }

        /// <summary>
        /// 事件发生时间
        /// </summary>
        [JsonProperty("createdTime", NullValueHandling = NullValueHandling.Ignore)]
        public long? CreatedTime { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WorkflowRunStreamRsp {\n");
            sb.Append("  Event: ").Append(Event).Append("\n");
            sb.Append("  conversationId: ").Append(ConversationId).Append("\n");
            sb.Append("  data: ").Append(Data).Append("\n");
            sb.Append("  createdTime: ").Append(CreatedTime).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as WorkflowRunStreamRsp);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(WorkflowRunStreamRsp input)
        {
            if (input == null) return false;
            if (this.Event != input.Event || (this.Event != null && !this.Event.Equals(input.Event))) return false;
            if (this.ConversationId != input.ConversationId || (this.ConversationId != null && !this.ConversationId.Equals(input.ConversationId))) return false;
            if (this.Data != input.Data || (this.Data != null && !this.Data.Equals(input.Data))) return false;
            if (this.CreatedTime != input.CreatedTime || (this.CreatedTime != null && !this.CreatedTime.Equals(input.CreatedTime))) return false;

            return true;
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                if (this.Event != null) hashCode = hashCode * 59 + this.Event.GetHashCode();
                if (this.ConversationId != null) hashCode = hashCode * 59 + this.ConversationId.GetHashCode();
                if (this.Data != null) hashCode = hashCode * 59 + this.Data.GetHashCode();
                if (this.CreatedTime != null) hashCode = hashCode * 59 + this.CreatedTime.GetHashCode();
                return hashCode;
            }
        }
    }
}
