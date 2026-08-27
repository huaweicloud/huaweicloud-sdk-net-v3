using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.IoTDA.V5.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class CreateProtocolConfigResponse : SdkResponse
    {

        /// <summary>
        /// **参数说明**：泛协议配置ID。
        /// </summary>
        [JsonProperty("protocol_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProtocolId { get; set; }

        /// <summary>
        /// **参数说明**：泛协议配置的端口号。
        /// </summary>
        [JsonProperty("port", NullValueHandling = NullValueHandling.Ignore)]
        public int? Port { get; set; }

        /// <summary>
        /// **参数说明**：连接空闲断链时间，单位（s）。
        /// </summary>
        [JsonProperty("keepalive_timeout", NullValueHandling = NullValueHandling.Ignore)]
        public int? KeepaliveTimeout { get; set; }

        /// <summary>
        /// **参数说明**：协议类型。 **取值范围**： - TCP：通用TCP协议接入
        /// </summary>
        [JsonProperty("protocol_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ProtocolType { get; set; }

        /// <summary>
        /// **参数说明**：泛协议的描述信息。 **取值范围**：长度不超过2048，只允许中文、字母、数字、以及_?&#39;#().,&amp;%@!-等字符的组合
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// **参数说明**：是否开启tls加密传输。
        /// </summary>
        [JsonProperty("ssl_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? SslEnable { get; set; }

        /// <summary>
        /// **参数说明**：码流拆包组包配置列表。
        /// </summary>
        [JsonProperty("frame_decode_configs", NullValueHandling = NullValueHandling.Ignore)]
        public List<FrameDecodeConfig> FrameDecodeConfigs { get; set; }

        /// <summary>
        /// **参数说明**：编解码类型。 **取值范围**： - FGS：将编解码插件以函数形式部署到FunctionGraph。 - PLUGIN：将编解码插件以OSGI插件形式部署到设备接入平台，使用该方式需提工单联系技术支持。
        /// </summary>
        [JsonProperty("codec_mode", NullValueHandling = NullValueHandling.Ignore)]
        public string CodecMode { get; set; }

        /// <summary>
        /// **参数说明**：函数的URN（Uniform Resource Name），唯一标识函数，采用FGS进行编解码的对应函数地址。 **取值范围**：长度不超过256，只允许字母、数字、下划线（_）、连接符（-）、分隔符（:）的组合。
        /// </summary>
        [JsonProperty("func_urn", NullValueHandling = NullValueHandling.Ignore)]
        public string FuncUrn { get; set; }

        /// <summary>
        /// **参数说明**：在物联网平台查询自定义鉴权的时间。格式：yyyyMMdd&#39;T&#39;HHmmss&#39;Z&#39;，如：20151212T121212Z。
        /// </summary>
        [JsonProperty("create_time", NullValueHandling = NullValueHandling.Ignore)]
        public string CreateTime { get; set; }

        /// <summary>
        /// **参数说明**：在物联网平台更新查询自定义鉴权的时间。格式：yyyyMMdd&#39;T&#39;HHmmss&#39;Z&#39;，如：20151212T121212Z。
        /// </summary>
        [JsonProperty("update_time", NullValueHandling = NullValueHandling.Ignore)]
        public string UpdateTime { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateProtocolConfigResponse {\n");
            sb.Append("  protocolId: ").Append(ProtocolId).Append("\n");
            sb.Append("  port: ").Append(Port).Append("\n");
            sb.Append("  keepaliveTimeout: ").Append(KeepaliveTimeout).Append("\n");
            sb.Append("  protocolType: ").Append(ProtocolType).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  sslEnable: ").Append(SslEnable).Append("\n");
            sb.Append("  frameDecodeConfigs: ").Append(FrameDecodeConfigs).Append("\n");
            sb.Append("  codecMode: ").Append(CodecMode).Append("\n");
            sb.Append("  funcUrn: ").Append(FuncUrn).Append("\n");
            sb.Append("  createTime: ").Append(CreateTime).Append("\n");
            sb.Append("  updateTime: ").Append(UpdateTime).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateProtocolConfigResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateProtocolConfigResponse input)
        {
            if (input == null) return false;
            if (this.ProtocolId != input.ProtocolId || (this.ProtocolId != null && !this.ProtocolId.Equals(input.ProtocolId))) return false;
            if (this.Port != input.Port || (this.Port != null && !this.Port.Equals(input.Port))) return false;
            if (this.KeepaliveTimeout != input.KeepaliveTimeout || (this.KeepaliveTimeout != null && !this.KeepaliveTimeout.Equals(input.KeepaliveTimeout))) return false;
            if (this.ProtocolType != input.ProtocolType || (this.ProtocolType != null && !this.ProtocolType.Equals(input.ProtocolType))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.SslEnable != input.SslEnable || (this.SslEnable != null && !this.SslEnable.Equals(input.SslEnable))) return false;
            if (this.FrameDecodeConfigs != input.FrameDecodeConfigs || (this.FrameDecodeConfigs != null && input.FrameDecodeConfigs != null && !this.FrameDecodeConfigs.SequenceEqual(input.FrameDecodeConfigs))) return false;
            if (this.CodecMode != input.CodecMode || (this.CodecMode != null && !this.CodecMode.Equals(input.CodecMode))) return false;
            if (this.FuncUrn != input.FuncUrn || (this.FuncUrn != null && !this.FuncUrn.Equals(input.FuncUrn))) return false;
            if (this.CreateTime != input.CreateTime || (this.CreateTime != null && !this.CreateTime.Equals(input.CreateTime))) return false;
            if (this.UpdateTime != input.UpdateTime || (this.UpdateTime != null && !this.UpdateTime.Equals(input.UpdateTime))) return false;

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
                if (this.ProtocolId != null) hashCode = hashCode * 59 + this.ProtocolId.GetHashCode();
                if (this.Port != null) hashCode = hashCode * 59 + this.Port.GetHashCode();
                if (this.KeepaliveTimeout != null) hashCode = hashCode * 59 + this.KeepaliveTimeout.GetHashCode();
                if (this.ProtocolType != null) hashCode = hashCode * 59 + this.ProtocolType.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.SslEnable != null) hashCode = hashCode * 59 + this.SslEnable.GetHashCode();
                if (this.FrameDecodeConfigs != null) hashCode = hashCode * 59 + this.FrameDecodeConfigs.GetHashCode();
                if (this.CodecMode != null) hashCode = hashCode * 59 + this.CodecMode.GetHashCode();
                if (this.FuncUrn != null) hashCode = hashCode * 59 + this.FuncUrn.GetHashCode();
                if (this.CreateTime != null) hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
                if (this.UpdateTime != null) hashCode = hashCode * 59 + this.UpdateTime.GetHashCode();
                return hashCode;
            }
        }
    }
}
