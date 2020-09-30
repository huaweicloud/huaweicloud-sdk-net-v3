using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Rabbitmq.V2.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ListInstancesDetailsRequest 
    {
        /// <summary>
        /// Defines engine
        /// </summary>
        [JsonConverter(typeof(EnumClassConverter<EngineEnum>))]
        public class EngineEnum
        {
            /// <summary>
            /// Enum RABBITMQ for value: rabbitmq
            /// </summary>
            public static readonly EngineEnum RABBITMQ = new EngineEnum("rabbitmq");

            private static readonly Dictionary<string, EngineEnum> StaticFields =
            new Dictionary<string, EngineEnum>()
            {
                { "rabbitmq", RABBITMQ },
            };

            private string Value;

            private EngineEnum(string value)
            {
                this.Value = value;
            }

            public static EngineEnum FromValue(string value)
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
                return this.Value;
            }

            public override int GetHashCode()
            {
                return this.Value.GetHashCode();
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

                if (this.Equals(obj as EngineEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(EngineEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this.Value, obj.Value);
            }

            public static bool operator ==(EngineEnum a, EngineEnum b)
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

            public static bool operator !=(EngineEnum a, EngineEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// Defines status
        /// </summary>
        [JsonConverter(typeof(EnumClassConverter<StatusEnum>))]
        public class StatusEnum
        {
            /// <summary>
            /// Enum CREATING for value: CREATING
            /// </summary>
            public static readonly StatusEnum CREATING = new StatusEnum("CREATING");

            /// <summary>
            /// Enum CREATEFAILED for value: CREATEFAILED
            /// </summary>
            public static readonly StatusEnum CREATEFAILED = new StatusEnum("CREATEFAILED");

            /// <summary>
            /// Enum RUNNING for value: RUNNING
            /// </summary>
            public static readonly StatusEnum RUNNING = new StatusEnum("RUNNING");

            /// <summary>
            /// Enum ERROR for value: ERROR
            /// </summary>
            public static readonly StatusEnum ERROR = new StatusEnum("ERROR");

            /// <summary>
            /// Enum STARTING for value: STARTING
            /// </summary>
            public static readonly StatusEnum STARTING = new StatusEnum("STARTING");

            /// <summary>
            /// Enum RESTARTING for value: RESTARTING
            /// </summary>
            public static readonly StatusEnum RESTARTING = new StatusEnum("RESTARTING");

            /// <summary>
            /// Enum CLOSING for value: CLOSING
            /// </summary>
            public static readonly StatusEnum CLOSING = new StatusEnum("CLOSING");

            /// <summary>
            /// Enum FROZEN for value: FROZEN
            /// </summary>
            public static readonly StatusEnum FROZEN = new StatusEnum("FROZEN");

            private static readonly Dictionary<string, StatusEnum> StaticFields =
            new Dictionary<string, StatusEnum>()
            {
                { "CREATING", CREATING },
                { "CREATEFAILED", CREATEFAILED },
                { "RUNNING", RUNNING },
                { "ERROR", ERROR },
                { "STARTING", STARTING },
                { "RESTARTING", RESTARTING },
                { "CLOSING", CLOSING },
                { "FROZEN", FROZEN },
            };

            private string Value;

            private StatusEnum(string value)
            {
                this.Value = value;
            }

            public static StatusEnum FromValue(string value)
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
                return this.Value;
            }

            public override int GetHashCode()
            {
                return this.Value.GetHashCode();
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

                if (this.Equals(obj as StatusEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(StatusEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this.Value, obj.Value);
            }

            public static bool operator ==(StatusEnum a, StatusEnum b)
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

            public static bool operator !=(StatusEnum a, StatusEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// Defines includeFailure
        /// </summary>
        [JsonConverter(typeof(EnumClassConverter<IncludeFailureEnum>))]
        public class IncludeFailureEnum
        {
            /// <summary>
            /// Enum TRUE for value: true
            /// </summary>
            public static readonly IncludeFailureEnum TRUE = new IncludeFailureEnum("true");

            /// <summary>
            /// Enum FALSE for value: false
            /// </summary>
            public static readonly IncludeFailureEnum FALSE = new IncludeFailureEnum("false");

            private static readonly Dictionary<string, IncludeFailureEnum> StaticFields =
            new Dictionary<string, IncludeFailureEnum>()
            {
                { "true", TRUE },
                { "false", FALSE },
            };

            private string Value;

            private IncludeFailureEnum(string value)
            {
                this.Value = value;
            }

            public static IncludeFailureEnum FromValue(string value)
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
                return this.Value;
            }

            public override int GetHashCode()
            {
                return this.Value.GetHashCode();
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

                if (this.Equals(obj as IncludeFailureEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(IncludeFailureEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this.Value, obj.Value);
            }

            public static bool operator ==(IncludeFailureEnum a, IncludeFailureEnum b)
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

            public static bool operator !=(IncludeFailureEnum a, IncludeFailureEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// Defines exactMatchName
        /// </summary>
        [JsonConverter(typeof(EnumClassConverter<ExactMatchNameEnum>))]
        public class ExactMatchNameEnum
        {
            /// <summary>
            /// Enum TRUE for value: true
            /// </summary>
            public static readonly ExactMatchNameEnum TRUE = new ExactMatchNameEnum("true");

            /// <summary>
            /// Enum FALSE for value: false
            /// </summary>
            public static readonly ExactMatchNameEnum FALSE = new ExactMatchNameEnum("false");

            private static readonly Dictionary<string, ExactMatchNameEnum> StaticFields =
            new Dictionary<string, ExactMatchNameEnum>()
            {
                { "true", TRUE },
                { "false", FALSE },
            };

            private string Value;

            private ExactMatchNameEnum(string value)
            {
                this.Value = value;
            }

            public static ExactMatchNameEnum FromValue(string value)
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
                return this.Value;
            }

            public override int GetHashCode()
            {
                return this.Value.GetHashCode();
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

                if (this.Equals(obj as ExactMatchNameEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ExactMatchNameEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this.Value, obj.Value);
            }

            public static bool operator ==(ExactMatchNameEnum a, ExactMatchNameEnum b)
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

            public static bool operator !=(ExactMatchNameEnum a, ExactMatchNameEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("engine", IsQuery = true)]
        [JsonProperty("engine", NullValueHandling = NullValueHandling.Ignore)]
        public EngineEnum Engine { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("name", IsQuery = true)]
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("instance_id", IsQuery = true)]
        [JsonProperty("instance_id", NullValueHandling = NullValueHandling.Ignore)]
        public string InstanceId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("status", IsQuery = true)]
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public StatusEnum Status { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("include_failure", IsQuery = true)]
        [JsonProperty("include_failure", NullValueHandling = NullValueHandling.Ignore)]
        public IncludeFailureEnum IncludeFailure { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("exact_match_name", IsQuery = true)]
        [JsonProperty("exact_match_name", NullValueHandling = NullValueHandling.Ignore)]
        public ExactMatchNameEnum ExactMatchName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("enterprise_project_id", IsQuery = true)]
        [JsonProperty("enterprise_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EnterpriseProjectId { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListInstancesDetailsRequest {\n");
            sb.Append("  engine: ").Append(Engine).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  instanceId: ").Append(InstanceId).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  includeFailure: ").Append(IncludeFailure).Append("\n");
            sb.Append("  exactMatchName: ").Append(ExactMatchName).Append("\n");
            sb.Append("  enterpriseProjectId: ").Append(EnterpriseProjectId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListInstancesDetailsRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListInstancesDetailsRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Engine == input.Engine ||
                    (this.Engine != null &&
                    this.Engine.Equals(input.Engine))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.InstanceId == input.InstanceId ||
                    (this.InstanceId != null &&
                    this.InstanceId.Equals(input.InstanceId))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.IncludeFailure == input.IncludeFailure ||
                    (this.IncludeFailure != null &&
                    this.IncludeFailure.Equals(input.IncludeFailure))
                ) && 
                (
                    this.ExactMatchName == input.ExactMatchName ||
                    (this.ExactMatchName != null &&
                    this.ExactMatchName.Equals(input.ExactMatchName))
                ) && 
                (
                    this.EnterpriseProjectId == input.EnterpriseProjectId ||
                    (this.EnterpriseProjectId != null &&
                    this.EnterpriseProjectId.Equals(input.EnterpriseProjectId))
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
                if (this.Engine != null)
                    hashCode = hashCode * 59 + this.Engine.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.InstanceId != null)
                    hashCode = hashCode * 59 + this.InstanceId.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.IncludeFailure != null)
                    hashCode = hashCode * 59 + this.IncludeFailure.GetHashCode();
                if (this.ExactMatchName != null)
                    hashCode = hashCode * 59 + this.ExactMatchName.GetHashCode();
                if (this.EnterpriseProjectId != null)
                    hashCode = hashCode * 59 + this.EnterpriseProjectId.GetHashCode();
                return hashCode;
            }
        }
    }
}
