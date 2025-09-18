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
    /// 
    /// </summary>
    public class UpdateTaskV2RequestBody 
    {
        /// <summary>
        /// 部署系统，deployTemplate：部署模板
        /// </summary>
        /// <value>部署系统，deployTemplate：部署模板</value>
        [JsonConverter(typeof(EnumClassConverter<DeploySystemEnum>))]
        public class DeploySystemEnum
        {
            /// <summary>
            /// Enum DEPLOYTEMPLATE for value: deployTemplate
            /// </summary>
            public static readonly DeploySystemEnum DEPLOYTEMPLATE = new DeploySystemEnum("deployTemplate");

            private static readonly Dictionary<string, DeploySystemEnum> StaticFields =
            new Dictionary<string, DeploySystemEnum>()
            {
                { "deployTemplate", DEPLOYTEMPLATE },
            };

            private string _value;

            public DeploySystemEnum()
            {

            }

            public DeploySystemEnum(string value)
            {
                _value = value;
            }

            public static DeploySystemEnum FromValue(string value)
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

                if (this.Equals(obj as DeploySystemEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(DeploySystemEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(DeploySystemEnum a, DeploySystemEnum b)
            {
                if (ReferenceEquals(a, b))
                {
                    return true;
                }

                if ((object)a == null)
                {
                    return false;
                }

                return a.Equals(b);
            }

            public static bool operator !=(DeploySystemEnum a, DeploySystemEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 部署任务id
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 部署系统，deployTemplate：部署模板
        /// </summary>
        [JsonProperty("deploy_system", NullValueHandling = NullValueHandling.Ignore)]
        public DeploySystemEnum DeploySystem { get; set; }
        /// <summary>
        /// 部署模板实例id
        /// </summary>
        [JsonProperty("template_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TemplateId { get; set; }

        /// <summary>
        /// 部署编排列表信息
        /// </summary>
        [JsonProperty("operation_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<DeployV2OperationsDO> OperationList { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateTaskV2RequestBody {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  deploySystem: ").Append(DeploySystem).Append("\n");
            sb.Append("  templateId: ").Append(TemplateId).Append("\n");
            sb.Append("  operationList: ").Append(OperationList).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateTaskV2RequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateTaskV2RequestBody input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.DeploySystem != input.DeploySystem) return false;
            if (this.TemplateId != input.TemplateId || (this.TemplateId != null && !this.TemplateId.Equals(input.TemplateId))) return false;
            if (this.OperationList != input.OperationList || (this.OperationList != null && input.OperationList != null && !this.OperationList.SequenceEqual(input.OperationList))) return false;

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
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                hashCode = hashCode * 59 + this.DeploySystem.GetHashCode();
                if (this.TemplateId != null) hashCode = hashCode * 59 + this.TemplateId.GetHashCode();
                if (this.OperationList != null) hashCode = hashCode * 59 + this.OperationList.GetHashCode();
                return hashCode;
            }
        }
    }
}
