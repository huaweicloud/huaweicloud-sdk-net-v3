using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeArtsDeploy.V2.Model
{
    /// <summary>
    /// 创建应用请求体
    /// </summary>
    public class CreateAppRequestBody 
    {
        /// <summary>
        /// 创建类型，创建类型只有一个&#39;template&#39;，即根据模板创建
        /// </summary>
        /// <value>创建类型，创建类型只有一个&#39;template&#39;，即根据模板创建</value>
        [JsonConverter(typeof(EnumClassConverter<CreateTypeEnum>))]
        public class CreateTypeEnum
        {
            /// <summary>
            /// Enum TEMPLATE for value: template
            /// </summary>
            public static readonly CreateTypeEnum TEMPLATE = new CreateTypeEnum("template");

            private static readonly Dictionary<string, CreateTypeEnum> StaticFields =
            new Dictionary<string, CreateTypeEnum>()
            {
                { "template", TEMPLATE },
            };

            private string _value;

            public CreateTypeEnum()
            {

            }

            public CreateTypeEnum(string value)
            {
                _value = value;
            }

            public static CreateTypeEnum FromValue(string value)
            {
                if(value == null){
                    return null;
                }

                if (StaticFields.ContainsKey(value))
                {
                    return StaticFields[value];
                }

                return null;
            }

            public string GetValue()
            {
                return _value;
            }

            public override string ToString()
            {
                return $"{_value}";
            }

            public override int GetHashCode()
            {
                return this._value.GetHashCode();
            }

            public override bool Equals(object obj)
            {
                if (obj == null)
                {
                    return false;
                }

                if (ReferenceEquals(this, obj))
                {
                    return true;
                }

                if (this.Equals(obj as CreateTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(CreateTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(CreateTypeEnum a, CreateTypeEnum b)
            {
                if (System.Object.ReferenceEquals(a, b))
                {
                    return true;
                }

                if ((object)a == null)
                {
                    return false;
                }

                return a.Equals(b);
            }

            public static bool operator !=(CreateTypeEnum a, CreateTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 项目ID
        /// </summary>
        [JsonProperty("project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectId { get; set; }

        /// <summary>
        /// 应用名称
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 是否为草稿
        /// </summary>
        [JsonProperty("is_draft", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsDraft { get; set; }

        /// <summary>
        /// 创建类型，创建类型只有一个&#39;template&#39;，即根据模板创建
        /// </summary>
        [JsonProperty("create_type", NullValueHandling = NullValueHandling.Ignore)]
        public CreateTypeEnum CreateType { get; set; }
        /// <summary>
        /// 自定义slave资源池id
        /// </summary>
        [JsonProperty("slave_cluster_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SlaveClusterId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("trigger", NullValueHandling = NullValueHandling.Ignore)]
        public TaskTriggerVO Trigger { get; set; }

        /// <summary>
        /// 部署任务列表信息
        /// </summary>
        [JsonProperty("arrange_infos", NullValueHandling = NullValueHandling.Ignore)]
        public List<TaskV2RequestBody> ArrangeInfos { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateAppRequestBody {\n");
            sb.Append("  projectId: ").Append(ProjectId).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  isDraft: ").Append(IsDraft).Append("\n");
            sb.Append("  createType: ").Append(CreateType).Append("\n");
            sb.Append("  slaveClusterId: ").Append(SlaveClusterId).Append("\n");
            sb.Append("  trigger: ").Append(Trigger).Append("\n");
            sb.Append("  arrangeInfos: ").Append(ArrangeInfos).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateAppRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateAppRequestBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ProjectId == input.ProjectId ||
                    (this.ProjectId != null &&
                    this.ProjectId.Equals(input.ProjectId))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.IsDraft == input.IsDraft ||
                    (this.IsDraft != null &&
                    this.IsDraft.Equals(input.IsDraft))
                ) && 
                (
                    this.CreateType == input.CreateType ||
                    (this.CreateType != null &&
                    this.CreateType.Equals(input.CreateType))
                ) && 
                (
                    this.SlaveClusterId == input.SlaveClusterId ||
                    (this.SlaveClusterId != null &&
                    this.SlaveClusterId.Equals(input.SlaveClusterId))
                ) && 
                (
                    this.Trigger == input.Trigger ||
                    (this.Trigger != null &&
                    this.Trigger.Equals(input.Trigger))
                ) && 
                (
                    this.ArrangeInfos == input.ArrangeInfos ||
                    this.ArrangeInfos != null &&
                    input.ArrangeInfos != null &&
                    this.ArrangeInfos.SequenceEqual(input.ArrangeInfos)
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
                if (this.ProjectId != null)
                    hashCode = hashCode * 59 + this.ProjectId.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.IsDraft != null)
                    hashCode = hashCode * 59 + this.IsDraft.GetHashCode();
                if (this.CreateType != null)
                    hashCode = hashCode * 59 + this.CreateType.GetHashCode();
                if (this.SlaveClusterId != null)
                    hashCode = hashCode * 59 + this.SlaveClusterId.GetHashCode();
                if (this.Trigger != null)
                    hashCode = hashCode * 59 + this.Trigger.GetHashCode();
                if (this.ArrangeInfos != null)
                    hashCode = hashCode * 59 + this.ArrangeInfos.GetHashCode();
                return hashCode;
            }
        }
    }
}
