using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Aos.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class CreateStackSetRequestBody 
    {
        /// <summary>
        /// 权限模型，定义了RFS操作资源栈集时所需委托的创建方式，枚举值    * &#x60;SELF_MANAGED&#x60; - 基于部署需求，用户需要提前手动创建委托，既包含管理账号给RFS的委托，也包含成员账号创建给管理账号的委托。如果委托不存在或错误，创建资源栈集不会失败，部署资源栈集或部署资源栈实例的时候才会报错。
        /// </summary>
        /// <value>权限模型，定义了RFS操作资源栈集时所需委托的创建方式，枚举值    * &#x60;SELF_MANAGED&#x60; - 基于部署需求，用户需要提前手动创建委托，既包含管理账号给RFS的委托，也包含成员账号创建给管理账号的委托。如果委托不存在或错误，创建资源栈集不会失败，部署资源栈集或部署资源栈实例的时候才会报错。</value>
        [JsonConverter(typeof(EnumClassConverter<PermissionModelEnum>))]
        public class PermissionModelEnum
        {
            /// <summary>
            /// Enum SELF_MANAGED for value: SELF_MANAGED
            /// </summary>
            public static readonly PermissionModelEnum SELF_MANAGED = new PermissionModelEnum("SELF_MANAGED");

            private static readonly Dictionary<string, PermissionModelEnum> StaticFields =
            new Dictionary<string, PermissionModelEnum>()
            {
                { "SELF_MANAGED", SELF_MANAGED },
            };

            private string _value;

            public PermissionModelEnum()
            {

            }

            public PermissionModelEnum(string value)
            {
                _value = value;
            }

            public static PermissionModelEnum FromValue(string value)
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

                if (this.Equals(obj as PermissionModelEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(PermissionModelEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(PermissionModelEnum a, PermissionModelEnum b)
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

            public static bool operator !=(PermissionModelEnum a, PermissionModelEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 资源栈集（stack_set）的名字。此名字在domain_id+region下应唯一，可以使用中文、大小写英文、数字、下划线、中划线。首字符需为中文或者英文，区分大小写。
        /// </summary>
        [JsonProperty("stack_set_name", NullValueHandling = NullValueHandling.Ignore)]
        public string StackSetName { get; set; }

        /// <summary>
        /// 资源栈集的描述。可用于客户识别自己的资源栈集。
        /// </summary>
        [JsonProperty("stack_set_description", NullValueHandling = NullValueHandling.Ignore)]
        public string StackSetDescription { get; set; }

        /// <summary>
        /// 权限模型，定义了RFS操作资源栈集时所需委托的创建方式，枚举值    * &#x60;SELF_MANAGED&#x60; - 基于部署需求，用户需要提前手动创建委托，既包含管理账号给RFS的委托，也包含成员账号创建给管理账号的委托。如果委托不存在或错误，创建资源栈集不会失败，部署资源栈集或部署资源栈实例的时候才会报错。
        /// </summary>
        [JsonProperty("permission_model", NullValueHandling = NullValueHandling.Ignore)]
        public PermissionModelEnum PermissionModel { get; set; }
        /// <summary>
        /// 管理委托名称  资源编排服务使用该委托获取成员账号委托给管理账号的权限  当用户定义SELF_MANAGED权限类型时，administration_agency_name和administration_agency_urn 必须有且只有一个存在。  推荐用户在使用v5委托时给与administration_agency_urn，administration_agency_name只支持接收v3委托名称，若给与了v5委托名称，则会在部署模板时失败。  当用户使用SERVICE_MANAGED权限类型时，指定该参数将报错400。  [创建委托及授权方式](https://support.huaweicloud.com/usermanual-iam/iam_06_0002.html)
        /// </summary>
        [JsonProperty("administration_agency_name", NullValueHandling = NullValueHandling.Ignore)]
        public string AdministrationAgencyName { get; set; }

        /// <summary>
        /// 被管理的委托名称。  资源编排服务会使用该委托获取实际部署资源所需要的权限  不同成员账号委托给管理账号的委托名称需要保持一致。暂不支持根据不同provider定义不同委托权限  当用户定义SELF_MANAGED权限类型时，必须指定该参数。当用户使用SERVICE_MANAGED权限类型时，指定该参数将报错400  [创建委托及授权方式](https://support.huaweicloud.com/usermanual-iam/iam_06_0002.html)
        /// </summary>
        [JsonProperty("managed_agency_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ManagedAgencyName { get; set; }

        /// <summary>
        /// HCL模板，描述了资源的目标状态。资源编排服务将比较此模板与当前远程资源的状态之间的区别。  template_body和template_uri 必须有且只有一个存在  **注意：**   * 资源栈集不支持敏感数据加密，资源编排服务会直接明文使用、log、展示、存储对应的template_body
        /// </summary>
        [JsonProperty("template_body", NullValueHandling = NullValueHandling.Ignore)]
        public string TemplateBody { get; set; }

        /// <summary>
        /// HCL模板的OBS地址，该模板描述了资源的目标状态。资源编排服务将比较此模板与当前远程资源的状态之间的区别  OBS地址支持同类型Region之间进行互相访问（Region分为通用Region和专属Region，通用Region指面向公共租户提供通用云服务的Region；专属Region指只承载同一类业务或只面向特定租户提供业务服务的专用Region）  对应的文件应该是纯tf文件或zip压缩包  纯tf文件需要以“.tf”或者“.tf.json”结尾，并遵守HCL语法，且文件的编码格式须为UTF-8  压缩包目前只支持zip格式，文件需要以\&quot;.zip\&quot;结尾。解压后的文件不得包含\&quot;.tfvars\&quot;文件。解压前最大支持1MB，解压后最大支持1MB。zip压缩包文件数量不能超过100个  template_body和template_uri 必须有且只有一个存在  **注意：**   * 资源栈集不支持敏感数据加密，资源编排服务会直接明文使用、log、展示、存储template_uri对应的模板文件内容。   * template_uri对应的模板文件若为zip类型，则内部的文件或文件夹名称长度不得超过255个字节，最深路径长度不得超过2048字节，zip包大小不得超过1MB
        /// </summary>
        [JsonProperty("template_uri", NullValueHandling = NullValueHandling.Ignore)]
        public string TemplateUri { get; set; }

        /// <summary>
        /// HCL参数文件的OBS地址。HCL模板支持参数传入，即，同一个模板可以给予不同的参数而达到不同的效果。  OBS地址支持同类型Region之间进行互相访问（Region分为通用Region和专属Region，通用Region指面向公共租户提供通用云服务的Region；专属Region指只承载同一类业务或只面向特定租户提供业务服务的专用Region）  * vars_uri需要指向一个OBS的pre-signed URL地址，其他地址暂不支持  * 资源编排服务支持vars_body和vars_uri，如果他们中声名了同一个变量，将报错400  * vars_uri中的内容使用HCL的tfvars格式，用户可以将“.tfvars”中的内容保存到文件并上传到OBS中，并将OBS pre-signed URL传递给vars_uri  * 资源栈集不支持敏感数据加密，资源编排服务会直接明文使用、log、展示、存储vars_uri对应的参数文件内容
        /// </summary>
        [JsonProperty("vars_uri", NullValueHandling = NullValueHandling.Ignore)]
        public string VarsUri { get; set; }

        /// <summary>
        /// HCL参数文件的内容。HCL模板支持参数传入，即，同一个模板可以给予不同的参数而达到不同的效果。  * vars_body使用HCL的tfvars格式，用户可以将“.tfvars”中的内容提交到vars_body中  * 资源编排服务支持vars_body和vars_uri，如果他们中声名了同一个变量，将报错400  * 如果vars_body过大，可以使用vars_uri  * 资源栈集不支持敏感数据加密，资源编排服务会直接明文使用、log、展示、存储对应的vars_body。
        /// </summary>
        [JsonProperty("vars_body", NullValueHandling = NullValueHandling.Ignore)]
        public string VarsBody { get; set; }

        /// <summary>
        /// 初始化资源栈描述。可用于客户识别被资源栈集所管理的资源栈。  资源栈集下的资源栈仅在创建时统一使用该描述。客户想要更新初始化资源栈描述，可以通过UpdateStackSet API。  后续更新资源栈集描述将不会同步更新已管理的资源栈描述。
        /// </summary>
        [JsonProperty("initial_stack_description", NullValueHandling = NullValueHandling.Ignore)]
        public string InitialStackDescription { get; set; }

        /// <summary>
        /// 管理委托URN  资源编排服务使用该委托获取成员账号委托给管理账号的权限  当用户定义SELF_MANAGED权限类型时，administration_agency_name和administration_agency_urn 必须有且只有一个存在。  推荐用户在使用v5委托时给与administration_agency_urn，administration_agency_name只支持接收普通委托名称，若给与了v5委托名称，则会在部署模板时失败。  当用户使用SERVICE_MANAGED权限类型时，指定该参数将报错400。
        /// </summary>
        [JsonProperty("administration_agency_urn", NullValueHandling = NullValueHandling.Ignore)]
        public string AdministrationAgencyUrn { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateStackSetRequestBody {\n");
            sb.Append("  stackSetName: ").Append(StackSetName).Append("\n");
            sb.Append("  stackSetDescription: ").Append(StackSetDescription).Append("\n");
            sb.Append("  permissionModel: ").Append(PermissionModel).Append("\n");
            sb.Append("  administrationAgencyName: ").Append(AdministrationAgencyName).Append("\n");
            sb.Append("  managedAgencyName: ").Append(ManagedAgencyName).Append("\n");
            sb.Append("  templateBody: ").Append(TemplateBody).Append("\n");
            sb.Append("  templateUri: ").Append(TemplateUri).Append("\n");
            sb.Append("  varsUri: ").Append(VarsUri).Append("\n");
            sb.Append("  varsBody: ").Append(VarsBody).Append("\n");
            sb.Append("  initialStackDescription: ").Append(InitialStackDescription).Append("\n");
            sb.Append("  administrationAgencyUrn: ").Append(AdministrationAgencyUrn).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateStackSetRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateStackSetRequestBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.StackSetName == input.StackSetName ||
                    (this.StackSetName != null &&
                    this.StackSetName.Equals(input.StackSetName))
                ) && 
                (
                    this.StackSetDescription == input.StackSetDescription ||
                    (this.StackSetDescription != null &&
                    this.StackSetDescription.Equals(input.StackSetDescription))
                ) && 
                (
                    this.PermissionModel == input.PermissionModel ||
                    (this.PermissionModel != null &&
                    this.PermissionModel.Equals(input.PermissionModel))
                ) && 
                (
                    this.AdministrationAgencyName == input.AdministrationAgencyName ||
                    (this.AdministrationAgencyName != null &&
                    this.AdministrationAgencyName.Equals(input.AdministrationAgencyName))
                ) && 
                (
                    this.ManagedAgencyName == input.ManagedAgencyName ||
                    (this.ManagedAgencyName != null &&
                    this.ManagedAgencyName.Equals(input.ManagedAgencyName))
                ) && 
                (
                    this.TemplateBody == input.TemplateBody ||
                    (this.TemplateBody != null &&
                    this.TemplateBody.Equals(input.TemplateBody))
                ) && 
                (
                    this.TemplateUri == input.TemplateUri ||
                    (this.TemplateUri != null &&
                    this.TemplateUri.Equals(input.TemplateUri))
                ) && 
                (
                    this.VarsUri == input.VarsUri ||
                    (this.VarsUri != null &&
                    this.VarsUri.Equals(input.VarsUri))
                ) && 
                (
                    this.VarsBody == input.VarsBody ||
                    (this.VarsBody != null &&
                    this.VarsBody.Equals(input.VarsBody))
                ) && 
                (
                    this.InitialStackDescription == input.InitialStackDescription ||
                    (this.InitialStackDescription != null &&
                    this.InitialStackDescription.Equals(input.InitialStackDescription))
                ) && 
                (
                    this.AdministrationAgencyUrn == input.AdministrationAgencyUrn ||
                    (this.AdministrationAgencyUrn != null &&
                    this.AdministrationAgencyUrn.Equals(input.AdministrationAgencyUrn))
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
                if (this.StackSetName != null)
                    hashCode = hashCode * 59 + this.StackSetName.GetHashCode();
                if (this.StackSetDescription != null)
                    hashCode = hashCode * 59 + this.StackSetDescription.GetHashCode();
                if (this.PermissionModel != null)
                    hashCode = hashCode * 59 + this.PermissionModel.GetHashCode();
                if (this.AdministrationAgencyName != null)
                    hashCode = hashCode * 59 + this.AdministrationAgencyName.GetHashCode();
                if (this.ManagedAgencyName != null)
                    hashCode = hashCode * 59 + this.ManagedAgencyName.GetHashCode();
                if (this.TemplateBody != null)
                    hashCode = hashCode * 59 + this.TemplateBody.GetHashCode();
                if (this.TemplateUri != null)
                    hashCode = hashCode * 59 + this.TemplateUri.GetHashCode();
                if (this.VarsUri != null)
                    hashCode = hashCode * 59 + this.VarsUri.GetHashCode();
                if (this.VarsBody != null)
                    hashCode = hashCode * 59 + this.VarsBody.GetHashCode();
                if (this.InitialStackDescription != null)
                    hashCode = hashCode * 59 + this.InitialStackDescription.GetHashCode();
                if (this.AdministrationAgencyUrn != null)
                    hashCode = hashCode * 59 + this.AdministrationAgencyUrn.GetHashCode();
                return hashCode;
            }
        }
    }
}
