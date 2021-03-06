using System.Collections.Generic;
using System.Threading.Tasks;

namespace NCI.OCPL.Api.Glossary
{
    /// <summary>
    /// Interface for the service for working with
    /// auto suggestions
    /// </summary>
    public interface IAutosuggestQueryService
    {
        /// <summary>
        /// Retrieves a portion of the overall set of glossary terms for a given combination of dictionary, audience, and language.
        /// </summary>
        /// <param name="dictionary">The specific dictionary to retrieve from.</param>
        /// <param name="audience">The target audience.</param>
        /// <param name="language">Language (English - en; Spanish - es).</param>
        /// <param name="query">The search query</param>
        /// <returns>A GlossaryTermResults object containing the desired records.</returns>        
        Task<List<GlossaryTerm>> getSuggestions(string dictionary, AudienceType audience, string language, string query);
    }

}