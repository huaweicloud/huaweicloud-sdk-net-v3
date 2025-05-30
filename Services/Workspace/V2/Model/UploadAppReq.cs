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
    /// 添加应用。
    /// </summary>
    public class UploadAppReq 
    {

        /// <summary>
        /// 应用名称,名称需满足如下规则: 1. 不可为全空格。 2. 不允许包含如下字符:^;|~&#x60;{}[]&lt;&gt;。 3. 长度1~128个字符。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 版本号。
        /// </summary>
        [JsonProperty("version", NullValueHandling = NullValueHandling.Ignore)]
        public string Version { get; set; }

        /// <summary>
        /// 描述。
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("authorization_type", NullValueHandling = NullValueHandling.Ignore)]
        public AssignType AuthorizationType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("app_file_store", NullValueHandling = NullValueHandling.Ignore)]
        public FileStoreLink AppFileStore { get; set; }

        /// <summary>
        /// 图片的路径,支持使用可访问的URL地址或DataURIscheme。 * &#x60;可访问的URL&#x60; - https://xxx.x.xx.x/xxx/xx.jpg。 * &#x60;DataURIscheme&#x60; -  data;image/png;base64,iVBORw0KGgoAAAANS; 注意使用dataURLStream时，字符串最大长度为87500，即最多使用约64KB大小的图片。
        /// </summary>
        [JsonProperty("app_icon_url", NullValueHandling = NullValueHandling.Ignore)]
        public string AppIconUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("install_type", NullValueHandling = NullValueHandling.Ignore)]
        public InstallType InstallType { get; set; }
        /// <summary>
        /// 安装命令(静默安装命令)。 例: ${FILE_PATH} /S。 预定义变量将采用以下值: ${FILE_PATH}: 应用安装包在桌面本地的存储路径。
        /// </summary>
        [JsonProperty("install_command", NullValueHandling = NullValueHandling.Ignore)]
        public string InstallCommand { get; set; }

        /// <summary>
        /// 卸载命令(静默卸载命令)。 例: msiexec /uninstall ${FILE_PATH} /quiet。 预定义变量将采用以下值: ${FILE_PATH}: 应用安装包在桌面本地的存储路径。
        /// </summary>
        [JsonProperty("uninstall_command", NullValueHandling = NullValueHandling.Ignore)]
        public string UninstallCommand { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("support_os", NullValueHandling = NullValueHandling.Ignore)]
        public OsTypeEnum SupportOs { get; set; }
        /// <summary>
        /// 分类ID。
        /// </summary>
        [JsonProperty("catalog_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CatalogId { get; set; }

        /// <summary>
        /// 安装信息。
        /// </summary>
        [JsonProperty("install_info", NullValueHandling = NullValueHandling.Ignore)]
        public string InstallInfo { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UploadAppReq {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  version: ").Append(Version).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  authorizationType: ").Append(AuthorizationType).Append("\n");
            sb.Append("  appFileStore: ").Append(AppFileStore).Append("\n");
            sb.Append("  appIconUrl: ").Append(AppIconUrl).Append("\n");
            sb.Append("  installType: ").Append(InstallType).Append("\n");
            sb.Append("  installCommand: ").Append(InstallCommand).Append("\n");
            sb.Append("  uninstallCommand: ").Append(UninstallCommand).Append("\n");
            sb.Append("  supportOs: ").Append(SupportOs).Append("\n");
            sb.Append("  catalogId: ").Append(CatalogId).Append("\n");
            sb.Append("  installInfo: ").Append(InstallInfo).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UploadAppReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UploadAppReq input)
        {
            if (input == null) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Version != input.Version || (this.Version != null && !this.Version.Equals(input.Version))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.AuthorizationType != input.AuthorizationType) return false;
            if (this.AppFileStore != input.AppFileStore || (this.AppFileStore != null && !this.AppFileStore.Equals(input.AppFileStore))) return false;
            if (this.AppIconUrl != input.AppIconUrl || (this.AppIconUrl != null && !this.AppIconUrl.Equals(input.AppIconUrl))) return false;
            if (this.InstallType != input.InstallType) return false;
            if (this.InstallCommand != input.InstallCommand || (this.InstallCommand != null && !this.InstallCommand.Equals(input.InstallCommand))) return false;
            if (this.UninstallCommand != input.UninstallCommand || (this.UninstallCommand != null && !this.UninstallCommand.Equals(input.UninstallCommand))) return false;
            if (this.SupportOs != input.SupportOs) return false;
            if (this.CatalogId != input.CatalogId || (this.CatalogId != null && !this.CatalogId.Equals(input.CatalogId))) return false;
            if (this.InstallInfo != input.InstallInfo || (this.InstallInfo != null && !this.InstallInfo.Equals(input.InstallInfo))) return false;

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
                if (this.Version != null) hashCode = hashCode * 59 + this.Version.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                hashCode = hashCode * 59 + this.AuthorizationType.GetHashCode();
                if (this.AppFileStore != null) hashCode = hashCode * 59 + this.AppFileStore.GetHashCode();
                if (this.AppIconUrl != null) hashCode = hashCode * 59 + this.AppIconUrl.GetHashCode();
                hashCode = hashCode * 59 + this.InstallType.GetHashCode();
                if (this.InstallCommand != null) hashCode = hashCode * 59 + this.InstallCommand.GetHashCode();
                if (this.UninstallCommand != null) hashCode = hashCode * 59 + this.UninstallCommand.GetHashCode();
                hashCode = hashCode * 59 + this.SupportOs.GetHashCode();
                if (this.CatalogId != null) hashCode = hashCode * 59 + this.CatalogId.GetHashCode();
                if (this.InstallInfo != null) hashCode = hashCode * 59 + this.InstallInfo.GetHashCode();
                return hashCode;
            }
        }
    }
}
