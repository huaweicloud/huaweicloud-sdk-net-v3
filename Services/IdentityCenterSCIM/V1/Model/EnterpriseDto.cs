using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.IdentityCenterSCIM.V1.Model
{
    /// <summary>
    /// 包含用户工作相关信息的对象
    /// </summary>
    public class EnterpriseDto 
    {

        /// <summary>
        /// 成本中心
        /// </summary>
        [JsonProperty("costCenter", NullValueHandling = NullValueHandling.Ignore)]
        public string CostCenter { get; set; }

        /// <summary>
        /// 部门
        /// </summary>
        [JsonProperty("department", NullValueHandling = NullValueHandling.Ignore)]
        public string Department { get; set; }

        /// <summary>
        /// 分部
        /// </summary>
        [JsonProperty("division", NullValueHandling = NullValueHandling.Ignore)]
        public string Division { get; set; }

        /// <summary>
        /// 员工编号
        /// </summary>
        [JsonProperty("employeeNumber", NullValueHandling = NullValueHandling.Ignore)]
        public string EmployeeNumber { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("manager", NullValueHandling = NullValueHandling.Ignore)]
        public ManagerDto Manager { get; set; }

        /// <summary>
        /// 组织
        /// </summary>
        [JsonProperty("organization", NullValueHandling = NullValueHandling.Ignore)]
        public string Organization { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EnterpriseDto {\n");
            sb.Append("  costCenter: ").Append(CostCenter).Append("\n");
            sb.Append("  department: ").Append(Department).Append("\n");
            sb.Append("  division: ").Append(Division).Append("\n");
            sb.Append("  employeeNumber: ").Append(EmployeeNumber).Append("\n");
            sb.Append("  manager: ").Append(Manager).Append("\n");
            sb.Append("  organization: ").Append(Organization).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as EnterpriseDto);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(EnterpriseDto input)
        {
            if (input == null) return false;
            if (this.CostCenter != input.CostCenter || (this.CostCenter != null && !this.CostCenter.Equals(input.CostCenter))) return false;
            if (this.Department != input.Department || (this.Department != null && !this.Department.Equals(input.Department))) return false;
            if (this.Division != input.Division || (this.Division != null && !this.Division.Equals(input.Division))) return false;
            if (this.EmployeeNumber != input.EmployeeNumber || (this.EmployeeNumber != null && !this.EmployeeNumber.Equals(input.EmployeeNumber))) return false;
            if (this.Manager != input.Manager || (this.Manager != null && !this.Manager.Equals(input.Manager))) return false;
            if (this.Organization != input.Organization || (this.Organization != null && !this.Organization.Equals(input.Organization))) return false;

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
                if (this.CostCenter != null) hashCode = hashCode * 59 + this.CostCenter.GetHashCode();
                if (this.Department != null) hashCode = hashCode * 59 + this.Department.GetHashCode();
                if (this.Division != null) hashCode = hashCode * 59 + this.Division.GetHashCode();
                if (this.EmployeeNumber != null) hashCode = hashCode * 59 + this.EmployeeNumber.GetHashCode();
                if (this.Manager != null) hashCode = hashCode * 59 + this.Manager.GetHashCode();
                if (this.Organization != null) hashCode = hashCode * 59 + this.Organization.GetHashCode();
                return hashCode;
            }
        }
    }
}
