using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDB.V3.Model
{
    /// <summary>
    /// 创建ClickHouse实例请求体。
    /// </summary>
    public class CreateChInstanceRequestBody 
    {

        /// <summary>
        /// ClickHouse实例名称。 - 4位到64位之间 - 必须以字母开头，可以包含字母、数字、中划线或下划线 - 不能包含其他特殊字符
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("engine", NullValueHandling = NullValueHandling.Ignore)]
        public ClickHouseEngineInfo Engine { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("ha", NullValueHandling = NullValueHandling.Ignore)]
        public CreateChInstanceRequestBodyHa Ha { get; set; }

        /// <summary>
        /// 节点规格ID，可通过“HTAP查询规格信息”获取。
        /// </summary>
        [JsonProperty("flavor_id", NullValueHandling = NullValueHandling.Ignore)]
        public string FlavorId { get; set; }

        /// <summary>
        /// root账户密码。 - 8~32个字符 - 包含大写字母、小写字母、数字或特殊字符(~ ! @ # % ^ * - _ &#x3D; + ? ,)中的三种
        /// </summary>
        [JsonProperty("db_root_pwd", NullValueHandling = NullValueHandling.Ignore)]
        public string DbRootPwd { get; set; }

        /// <summary>
        /// 可用区类型。 取值范围： - single：单可用区 - double：多可用区
        /// </summary>
        [JsonProperty("az_mode", NullValueHandling = NullValueHandling.Ignore)]
        public string AzMode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("volume", NullValueHandling = NullValueHandling.Ignore)]
        public CreateChInstanceRequestBodyVolume Volume { get; set; }

        /// <summary>
        /// 可用区码。  当ha中mode为Ha时，需要填写多个可用区，用\&quot;,\&quot; 分隔。例如：cn-southwest-244b,cn-southwest-244a
        /// </summary>
        [JsonProperty("az_code", NullValueHandling = NullValueHandling.Ignore)]
        public string AzCode { get; set; }

        /// <summary>
        /// 时区。默认为所属GaussDB(for MySQL)实例时区。
        /// </summary>
        [JsonProperty("time_zone", NullValueHandling = NullValueHandling.Ignore)]
        public string TimeZone { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("tags_info", NullValueHandling = NullValueHandling.Ignore)]
        public CreateChInstanceRequestBodyTagsInfo TagsInfo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("pay_info", NullValueHandling = NullValueHandling.Ignore)]
        public CreateChInstanceRequestBodyPayInfo PayInfo { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateChInstanceRequestBody {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  engine: ").Append(Engine).Append("\n");
            sb.Append("  ha: ").Append(Ha).Append("\n");
            sb.Append("  flavorId: ").Append(FlavorId).Append("\n");
            sb.Append("  dbRootPwd: ").Append(DbRootPwd).Append("\n");
            sb.Append("  azMode: ").Append(AzMode).Append("\n");
            sb.Append("  volume: ").Append(Volume).Append("\n");
            sb.Append("  azCode: ").Append(AzCode).Append("\n");
            sb.Append("  timeZone: ").Append(TimeZone).Append("\n");
            sb.Append("  tagsInfo: ").Append(TagsInfo).Append("\n");
            sb.Append("  payInfo: ").Append(PayInfo).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateChInstanceRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateChInstanceRequestBody input)
        {
            if (input == null) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Engine != input.Engine || (this.Engine != null && !this.Engine.Equals(input.Engine))) return false;
            if (this.Ha != input.Ha || (this.Ha != null && !this.Ha.Equals(input.Ha))) return false;
            if (this.FlavorId != input.FlavorId || (this.FlavorId != null && !this.FlavorId.Equals(input.FlavorId))) return false;
            if (this.DbRootPwd != input.DbRootPwd || (this.DbRootPwd != null && !this.DbRootPwd.Equals(input.DbRootPwd))) return false;
            if (this.AzMode != input.AzMode || (this.AzMode != null && !this.AzMode.Equals(input.AzMode))) return false;
            if (this.Volume != input.Volume || (this.Volume != null && !this.Volume.Equals(input.Volume))) return false;
            if (this.AzCode != input.AzCode || (this.AzCode != null && !this.AzCode.Equals(input.AzCode))) return false;
            if (this.TimeZone != input.TimeZone || (this.TimeZone != null && !this.TimeZone.Equals(input.TimeZone))) return false;
            if (this.TagsInfo != input.TagsInfo || (this.TagsInfo != null && !this.TagsInfo.Equals(input.TagsInfo))) return false;
            if (this.PayInfo != input.PayInfo || (this.PayInfo != null && !this.PayInfo.Equals(input.PayInfo))) return false;

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
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Engine != null) hashCode = hashCode * 59 + this.Engine.GetHashCode();
                if (this.Ha != null) hashCode = hashCode * 59 + this.Ha.GetHashCode();
                if (this.FlavorId != null) hashCode = hashCode * 59 + this.FlavorId.GetHashCode();
                if (this.DbRootPwd != null) hashCode = hashCode * 59 + this.DbRootPwd.GetHashCode();
                if (this.AzMode != null) hashCode = hashCode * 59 + this.AzMode.GetHashCode();
                if (this.Volume != null) hashCode = hashCode * 59 + this.Volume.GetHashCode();
                if (this.AzCode != null) hashCode = hashCode * 59 + this.AzCode.GetHashCode();
                if (this.TimeZone != null) hashCode = hashCode * 59 + this.TimeZone.GetHashCode();
                if (this.TagsInfo != null) hashCode = hashCode * 59 + this.TagsInfo.GetHashCode();
                if (this.PayInfo != null) hashCode = hashCode * 59 + this.PayInfo.GetHashCode();
                return hashCode;
            }
        }
    }
}
