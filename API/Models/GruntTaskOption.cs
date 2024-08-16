// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Covenant.API.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class GruntTaskOption
    {
        /// <summary>
        /// Initializes a new instance of the GruntTaskOption class.
        /// </summary>
        public GruntTaskOption()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the GruntTaskOption class.
        /// </summary>
        public GruntTaskOption(int? id = default(int?), string name = default(string), string value = default(string), string defaultValue = default(string), string description = default(string), IList<string> suggestedValues = default(IList<string>), bool? optional = default(bool?), bool? displayInCommand = default(bool?), bool? fileOption = default(bool?), int? gruntTaskId = default(int?))
        {
            Id = id;
            Name = name;
            Value = value;
            DefaultValue = defaultValue;
            Description = description;
            SuggestedValues = suggestedValues;
            Optional = optional;
            DisplayInCommand = displayInCommand;
            FileOption = fileOption;
            GruntTaskId = gruntTaskId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public int? Id { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public string Value { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "defaultValue")]
        public string DefaultValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "suggestedValues")]
        public IList<string> SuggestedValues { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "optional")]
        public bool? Optional { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "displayInCommand")]
        public bool? DisplayInCommand { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "fileOption")]
        public bool? FileOption { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "gruntTaskId")]
        public int? GruntTaskId { get; set; }

    }
}
