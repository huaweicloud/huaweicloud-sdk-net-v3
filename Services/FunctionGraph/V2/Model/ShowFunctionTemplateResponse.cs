using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.FunctionGraph.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowFunctionTemplateResponse : SdkResponse
    {

        /// <summary>
        /// 模板id
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 模板类型
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public int? Type { get; set; }

        /// <summary>
        /// 模板标题
        /// </summary>
        [JsonProperty("title", NullValueHandling = NullValueHandling.Ignore)]
        public string Title { get; set; }

        /// <summary>
        /// 模板名称
        /// </summary>
        [JsonProperty("template_name", NullValueHandling = NullValueHandling.Ignore)]
        public string TemplateName { get; set; }

        /// <summary>
        /// 模板描述
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 模板执行运行时
        /// </summary>
        [JsonProperty("runtime", NullValueHandling = NullValueHandling.Ignore)]
        public string Runtime { get; set; }

        /// <summary>
        /// 模板函数执行入口
        /// </summary>
        [JsonProperty("handler", NullValueHandling = NullValueHandling.Ignore)]
        public string Handler { get; set; }

        /// <summary>
        /// 代码类型
        /// </summary>
        [JsonProperty("code_type", NullValueHandling = NullValueHandling.Ignore)]
        public string CodeType { get; set; }

        /// <summary>
        /// 代码文件
        /// </summary>
        [JsonProperty("code", NullValueHandling = NullValueHandling.Ignore)]
        public string Code { get; set; }

        /// <summary>
        /// 函数执行超时时间，超时函数将被强行停止，范围3～259200秒。
        /// </summary>
        [JsonProperty("timeout", NullValueHandling = NullValueHandling.Ignore)]
        public int? Timeout { get; set; }

        /// <summary>
        /// 内存大小
        /// </summary>
        [JsonProperty("memory_size", NullValueHandling = NullValueHandling.Ignore)]
        public int? MemorySize { get; set; }

        /// <summary>
        /// 触发信息列表
        /// </summary>
        [JsonProperty("trigger_metadata_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<TriggerMetadataList> TriggerMetadataList { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("temp_detail", NullValueHandling = NullValueHandling.Ignore)]
        public TempDetail TempDetail { get; set; }

        /// <summary>
        /// 用户数据
        /// </summary>
        [JsonProperty("user_data", NullValueHandling = NullValueHandling.Ignore)]
        public string UserData { get; set; }

        /// <summary>
        /// 加密用户数据
        /// </summary>
        [JsonProperty("encrypted_user_data", NullValueHandling = NullValueHandling.Ignore)]
        public string EncryptedUserData { get; set; }

        /// <summary>
        /// 模板所需依赖列表
        /// </summary>
        [JsonProperty("dependencies", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Dependencies { get; set; }

        /// <summary>
        /// 模板使用场景
        /// </summary>
        [JsonProperty("scene", NullValueHandling = NullValueHandling.Ignore)]
        public string Scene { get; set; }

        /// <summary>
        /// 模板关联云服务
        /// </summary>
        [JsonProperty("service", NullValueHandling = NullValueHandling.Ignore)]
        public string Service { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowFunctionTemplateResponse {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  title: ").Append(Title).Append("\n");
            sb.Append("  templateName: ").Append(TemplateName).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  runtime: ").Append(Runtime).Append("\n");
            sb.Append("  handler: ").Append(Handler).Append("\n");
            sb.Append("  codeType: ").Append(CodeType).Append("\n");
            sb.Append("  code: ").Append(Code).Append("\n");
            sb.Append("  timeout: ").Append(Timeout).Append("\n");
            sb.Append("  memorySize: ").Append(MemorySize).Append("\n");
            sb.Append("  triggerMetadataList: ").Append(TriggerMetadataList).Append("\n");
            sb.Append("  tempDetail: ").Append(TempDetail).Append("\n");
            sb.Append("  userData: ").Append(UserData).Append("\n");
            sb.Append("  encryptedUserData: ").Append(EncryptedUserData).Append("\n");
            sb.Append("  dependencies: ").Append(Dependencies).Append("\n");
            sb.Append("  scene: ").Append(Scene).Append("\n");
            sb.Append("  service: ").Append(Service).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowFunctionTemplateResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowFunctionTemplateResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
                ) && 
                (
                    this.TemplateName == input.TemplateName ||
                    (this.TemplateName != null &&
                    this.TemplateName.Equals(input.TemplateName))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Runtime == input.Runtime ||
                    (this.Runtime != null &&
                    this.Runtime.Equals(input.Runtime))
                ) && 
                (
                    this.Handler == input.Handler ||
                    (this.Handler != null &&
                    this.Handler.Equals(input.Handler))
                ) && 
                (
                    this.CodeType == input.CodeType ||
                    (this.CodeType != null &&
                    this.CodeType.Equals(input.CodeType))
                ) && 
                (
                    this.Code == input.Code ||
                    (this.Code != null &&
                    this.Code.Equals(input.Code))
                ) && 
                (
                    this.Timeout == input.Timeout ||
                    (this.Timeout != null &&
                    this.Timeout.Equals(input.Timeout))
                ) && 
                (
                    this.MemorySize == input.MemorySize ||
                    (this.MemorySize != null &&
                    this.MemorySize.Equals(input.MemorySize))
                ) && 
                (
                    this.TriggerMetadataList == input.TriggerMetadataList ||
                    this.TriggerMetadataList != null &&
                    input.TriggerMetadataList != null &&
                    this.TriggerMetadataList.SequenceEqual(input.TriggerMetadataList)
                ) && 
                (
                    this.TempDetail == input.TempDetail ||
                    (this.TempDetail != null &&
                    this.TempDetail.Equals(input.TempDetail))
                ) && 
                (
                    this.UserData == input.UserData ||
                    (this.UserData != null &&
                    this.UserData.Equals(input.UserData))
                ) && 
                (
                    this.EncryptedUserData == input.EncryptedUserData ||
                    (this.EncryptedUserData != null &&
                    this.EncryptedUserData.Equals(input.EncryptedUserData))
                ) && 
                (
                    this.Dependencies == input.Dependencies ||
                    this.Dependencies != null &&
                    input.Dependencies != null &&
                    this.Dependencies.SequenceEqual(input.Dependencies)
                ) && 
                (
                    this.Scene == input.Scene ||
                    (this.Scene != null &&
                    this.Scene.Equals(input.Scene))
                ) && 
                (
                    this.Service == input.Service ||
                    (this.Service != null &&
                    this.Service.Equals(input.Service))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Title != null)
                    hashCode = hashCode * 59 + this.Title.GetHashCode();
                if (this.TemplateName != null)
                    hashCode = hashCode * 59 + this.TemplateName.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Runtime != null)
                    hashCode = hashCode * 59 + this.Runtime.GetHashCode();
                if (this.Handler != null)
                    hashCode = hashCode * 59 + this.Handler.GetHashCode();
                if (this.CodeType != null)
                    hashCode = hashCode * 59 + this.CodeType.GetHashCode();
                if (this.Code != null)
                    hashCode = hashCode * 59 + this.Code.GetHashCode();
                if (this.Timeout != null)
                    hashCode = hashCode * 59 + this.Timeout.GetHashCode();
                if (this.MemorySize != null)
                    hashCode = hashCode * 59 + this.MemorySize.GetHashCode();
                if (this.TriggerMetadataList != null)
                    hashCode = hashCode * 59 + this.TriggerMetadataList.GetHashCode();
                if (this.TempDetail != null)
                    hashCode = hashCode * 59 + this.TempDetail.GetHashCode();
                if (this.UserData != null)
                    hashCode = hashCode * 59 + this.UserData.GetHashCode();
                if (this.EncryptedUserData != null)
                    hashCode = hashCode * 59 + this.EncryptedUserData.GetHashCode();
                if (this.Dependencies != null)
                    hashCode = hashCode * 59 + this.Dependencies.GetHashCode();
                if (this.Scene != null)
                    hashCode = hashCode * 59 + this.Scene.GetHashCode();
                if (this.Service != null)
                    hashCode = hashCode * 59 + this.Service.GetHashCode();
                return hashCode;
            }
        }
    }
}
