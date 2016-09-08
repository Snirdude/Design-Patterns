using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FacebookApp
{
    class NameGeneratorByFullName : INameGenerator
    {
        private string m_FirstName;
        private string m_LastName;
        private Func<string, string, string> m_NameGenerationMethod;

        public NameGeneratorByFullName(string i_FirstName, string i_LastName, Func<string, string, string> i_NameGenerationMethod)
        {
            m_FirstName = i_FirstName;
            m_LastName = i_LastName;
            m_NameGenerationMethod = i_NameGenerationMethod;
        }

        public string GenerateName()
        {
            return m_NameGenerationMethod(m_FirstName, m_LastName);
        }
    }
}
