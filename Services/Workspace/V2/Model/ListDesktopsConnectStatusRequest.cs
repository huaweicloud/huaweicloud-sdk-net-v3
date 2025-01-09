using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Workspace.V2.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ListDesktopsConnectStatusRequest 
    {

        /// <summary>
        /// 桌面所属用户，批量筛选，最多不超过100个用户。
        /// </summary>
        [SDKProperty("user_names", IsQuery = true)]
        [JsonProperty("user_names", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> UserNames { get; set; }

        /// <summary>
        /// 桌面的连接状态。  - UNREGISTER：表示桌面未注册时的状态（桌面启动后，会自动注册）。关机后也会出现未注册的状态。 - REGISTERED：表示桌面注册以后，等待用户连接的状态。 - CONNECTED：表示用户已经成功连接，正在使用桌面。 - DISCONNECTED：表示桌面与客户端断开会话后显示的状态，可能为关闭客户端窗口，或客户端与桌面网络断开引起。
        /// </summary>
        [SDKProperty("connect_status", IsQuery = true)]
        [JsonProperty("connect_status", NullValueHandling = NullValueHandling.Ignore)]
        public string ConnectStatus { get; set; }

        /// <summary>
        /// 从查询结果中的第几条数据开始返回,用于分页查询，取值范围0-2000，默认从0开始。
        /// </summary>
        [SDKProperty("offset", IsQuery = true)]
        [JsonProperty("offset", NullValueHandling = NullValueHandling.Ignore)]
        public int? Offset { get; set; }

        /// <summary>
        /// 查询结果中想要返回的信息条目数量,用于分页查询，取值范围0-2000，默认值100。
        /// </summary>
        [SDKProperty("limit", IsQuery = true)]
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListDesktopsConnectStatusRequest {\n");
            sb.Append("  userNames: ").Append(UserNames).Append("\n");
            sb.Append("  connectStatus: ").Append(ConnectStatus).Append("\n");
            sb.Append("  offset: ").Append(Offset).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListDesktopsConnectStatusRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListDesktopsConnectStatusRequest input)
        {
            if (input == null) return false;
            if (this.UserNames != input.UserNames || (this.UserNames != null && input.UserNames != null && !this.UserNames.SequenceEqual(input.UserNames))) return false;
            if (this.ConnectStatus != input.ConnectStatus || (this.ConnectStatus != null && !this.ConnectStatus.Equals(input.ConnectStatus))) return false;
            if (this.Offset != input.Offset || (this.Offset != null && !this.Offset.Equals(input.Offset))) return false;
            if (this.Limit != input.Limit || (this.Limit != null && !this.Limit.Equals(input.Limit))) return false;

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
                if (this.UserNames != null) hashCode = hashCode * 59 + this.UserNames.GetHashCode();
                if (this.ConnectStatus != null) hashCode = hashCode * 59 + this.ConnectStatus.GetHashCode();
                if (this.Offset != null) hashCode = hashCode * 59 + this.Offset.GetHashCode();
                if (this.Limit != null) hashCode = hashCode * 59 + this.Limit.GetHashCode();
                return hashCode;
            }
        }
    }
}
