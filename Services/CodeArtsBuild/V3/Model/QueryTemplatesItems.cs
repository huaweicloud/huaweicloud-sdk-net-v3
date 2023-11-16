using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeArtsBuild.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class QueryTemplatesItems 
    {

        /// <summary>
        /// 是否收藏模板
        /// </summary>
        [JsonProperty("favourite", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Favourite { get; set; }

        /// <summary>
        /// 昵称
        /// </summary>
        [JsonProperty("nick_name", NullValueHandling = NullValueHandling.Ignore)]
        public string NickName { get; set; }

        /// <summary>
        /// 数据库中id
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// uuid
        /// </summary>
        [JsonProperty("uuid", NullValueHandling = NullValueHandling.Ignore)]
        public string Uuid { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("template", NullValueHandling = NullValueHandling.Ignore)]
        public QueryTemplate Template { get; set; }

        /// <summary>
        /// 模板类别
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// 模板是否公开
        /// </summary>
        [JsonProperty("public", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Public { get; set; }

        /// <summary>
        /// 模板命名
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("create_time", NullValueHandling = NullValueHandling.Ignore)]
        public string CreateTime { get; set; }

        /// <summary>
        /// domainId
        /// </summary>
        [JsonProperty("domain_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DomainId { get; set; }

        /// <summary>
        /// 权重
        /// </summary>
        [JsonProperty("weight", NullValueHandling = NullValueHandling.Ignore)]
        public double? Weight { get; set; }

        /// <summary>
        /// 用户id
        /// </summary>
        [JsonProperty("user_id", NullValueHandling = NullValueHandling.Ignore)]
        public string UserId { get; set; }

        /// <summary>
        /// 用户名
        /// </summary>
        [JsonProperty("user_name", NullValueHandling = NullValueHandling.Ignore)]
        public string UserName { get; set; }

        /// <summary>
        /// domain名字
        /// </summary>
        [JsonProperty("domain_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DomainName { get; set; }

        /// <summary>
        /// 模板范围，自定义模板默认为custom
        /// </summary>
        [JsonProperty("scope", NullValueHandling = NullValueHandling.Ignore)]
        public string Scope { get; set; }

        /// <summary>
        /// 模板说明
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 构建工具类型，yaml构建还是action构建
        /// </summary>
        [JsonProperty("tool_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ToolType { get; set; }

        /// <summary>
        /// intl说明
        /// </summary>
        [JsonProperty("intl_description", NullValueHandling = NullValueHandling.Ignore)]
        public Object IntlDescription { get; set; }

        /// <summary>
        /// 构建执行参数列表
        /// </summary>
        [JsonProperty("parameters", NullValueHandling = NullValueHandling.Ignore)]
        public List<CreateBuildJobParameter> Parameters { get; set; }

        /// <summary>
        /// i18n
        /// </summary>
        [JsonProperty("i18n", NullValueHandling = NullValueHandling.Ignore)]
        public Object I18n { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QueryTemplatesItems {\n");
            sb.Append("  favourite: ").Append(Favourite).Append("\n");
            sb.Append("  nickName: ").Append(NickName).Append("\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  uuid: ").Append(Uuid).Append("\n");
            sb.Append("  template: ").Append(Template).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  Public: ").Append(Public).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  createTime: ").Append(CreateTime).Append("\n");
            sb.Append("  domainId: ").Append(DomainId).Append("\n");
            sb.Append("  weight: ").Append(Weight).Append("\n");
            sb.Append("  userId: ").Append(UserId).Append("\n");
            sb.Append("  userName: ").Append(UserName).Append("\n");
            sb.Append("  domainName: ").Append(DomainName).Append("\n");
            sb.Append("  scope: ").Append(Scope).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  toolType: ").Append(ToolType).Append("\n");
            sb.Append("  intlDescription: ").Append(IntlDescription).Append("\n");
            sb.Append("  parameters: ").Append(Parameters).Append("\n");
            sb.Append("  i18n: ").Append(I18n).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as QueryTemplatesItems);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(QueryTemplatesItems input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Favourite == input.Favourite ||
                    (this.Favourite != null &&
                    this.Favourite.Equals(input.Favourite))
                ) && 
                (
                    this.NickName == input.NickName ||
                    (this.NickName != null &&
                    this.NickName.Equals(input.NickName))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Uuid == input.Uuid ||
                    (this.Uuid != null &&
                    this.Uuid.Equals(input.Uuid))
                ) && 
                (
                    this.Template == input.Template ||
                    (this.Template != null &&
                    this.Template.Equals(input.Template))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Public == input.Public ||
                    (this.Public != null &&
                    this.Public.Equals(input.Public))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.CreateTime == input.CreateTime ||
                    (this.CreateTime != null &&
                    this.CreateTime.Equals(input.CreateTime))
                ) && 
                (
                    this.DomainId == input.DomainId ||
                    (this.DomainId != null &&
                    this.DomainId.Equals(input.DomainId))
                ) && 
                (
                    this.Weight == input.Weight ||
                    (this.Weight != null &&
                    this.Weight.Equals(input.Weight))
                ) && 
                (
                    this.UserId == input.UserId ||
                    (this.UserId != null &&
                    this.UserId.Equals(input.UserId))
                ) && 
                (
                    this.UserName == input.UserName ||
                    (this.UserName != null &&
                    this.UserName.Equals(input.UserName))
                ) && 
                (
                    this.DomainName == input.DomainName ||
                    (this.DomainName != null &&
                    this.DomainName.Equals(input.DomainName))
                ) && 
                (
                    this.Scope == input.Scope ||
                    (this.Scope != null &&
                    this.Scope.Equals(input.Scope))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.ToolType == input.ToolType ||
                    (this.ToolType != null &&
                    this.ToolType.Equals(input.ToolType))
                ) && 
                (
                    this.IntlDescription == input.IntlDescription ||
                    (this.IntlDescription != null &&
                    this.IntlDescription.Equals(input.IntlDescription))
                ) && 
                (
                    this.Parameters == input.Parameters ||
                    this.Parameters != null &&
                    input.Parameters != null &&
                    this.Parameters.SequenceEqual(input.Parameters)
                ) && 
                (
                    this.I18n == input.I18n ||
                    (this.I18n != null &&
                    this.I18n.Equals(input.I18n))
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
                if (this.Favourite != null)
                    hashCode = hashCode * 59 + this.Favourite.GetHashCode();
                if (this.NickName != null)
                    hashCode = hashCode * 59 + this.NickName.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Uuid != null)
                    hashCode = hashCode * 59 + this.Uuid.GetHashCode();
                if (this.Template != null)
                    hashCode = hashCode * 59 + this.Template.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Public != null)
                    hashCode = hashCode * 59 + this.Public.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.CreateTime != null)
                    hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
                if (this.DomainId != null)
                    hashCode = hashCode * 59 + this.DomainId.GetHashCode();
                if (this.Weight != null)
                    hashCode = hashCode * 59 + this.Weight.GetHashCode();
                if (this.UserId != null)
                    hashCode = hashCode * 59 + this.UserId.GetHashCode();
                if (this.UserName != null)
                    hashCode = hashCode * 59 + this.UserName.GetHashCode();
                if (this.DomainName != null)
                    hashCode = hashCode * 59 + this.DomainName.GetHashCode();
                if (this.Scope != null)
                    hashCode = hashCode * 59 + this.Scope.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.ToolType != null)
                    hashCode = hashCode * 59 + this.ToolType.GetHashCode();
                if (this.IntlDescription != null)
                    hashCode = hashCode * 59 + this.IntlDescription.GetHashCode();
                if (this.Parameters != null)
                    hashCode = hashCode * 59 + this.Parameters.GetHashCode();
                if (this.I18n != null)
                    hashCode = hashCode * 59 + this.I18n.GetHashCode();
                return hashCode;
            }
        }
    }
}
