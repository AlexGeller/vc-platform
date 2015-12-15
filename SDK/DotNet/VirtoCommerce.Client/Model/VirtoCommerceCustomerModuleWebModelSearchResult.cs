using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;



namespace VirtoCommerce.Client.Model
{

    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public class VirtoCommerceCustomerModuleWebModelSearchResult : IEquatable<VirtoCommerceCustomerModuleWebModelSearchResult>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VirtoCommerceCustomerModuleWebModelSearchResult" /> class.
        /// </summary>
        public VirtoCommerceCustomerModuleWebModelSearchResult()
        {
            
        }

        
        /// <summary>
        /// Total count of objects satisfied Search Criteria
        /// </summary>
        /// <value>Total count of objects satisfied Search Criteria</value>
        [DataMember(Name="totalCount", EmitDefaultValue=false)]
        public int? TotalCount { get; set; }
  
        
        /// <summary>
        /// Part of objects satisfied Search Criteria. See Skip and Count parameters of Search Criteria
        /// </summary>
        /// <value>Part of objects satisfied Search Criteria. See Skip and Count parameters of Search Criteria</value>
        [DataMember(Name="members", EmitDefaultValue=false)]
        public List<VirtoCommerceCustomerModuleWebModelMember> Members { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VirtoCommerceCustomerModuleWebModelSearchResult {\n");
            sb.Append("  TotalCount: ").Append(TotalCount).Append("\n");
            sb.Append("  Members: ").Append(Members).Append("\n");
            
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as VirtoCommerceCustomerModuleWebModelSearchResult);
        }

        /// <summary>
        /// Returns true if VirtoCommerceCustomerModuleWebModelSearchResult instances are equal
        /// </summary>
        /// <param name="obj">Instance of VirtoCommerceCustomerModuleWebModelSearchResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VirtoCommerceCustomerModuleWebModelSearchResult other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.TotalCount == other.TotalCount ||
                    this.TotalCount != null &&
                    this.TotalCount.Equals(other.TotalCount)
                ) && 
                (
                    this.Members == other.Members ||
                    this.Members != null &&
                    this.Members.SequenceEqual(other.Members)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                
                if (this.TotalCount != null)
                    hash = hash * 57 + this.TotalCount.GetHashCode();
                
                if (this.Members != null)
                    hash = hash * 57 + this.Members.GetHashCode();
                
                return hash;
            }
        }

    }


}
