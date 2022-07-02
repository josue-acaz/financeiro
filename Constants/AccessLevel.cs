using System;

//var currentUserSecurityGroup = (SecurityGroup)Enum.Parse(typeof(SecurityGroup), Roles.GetRolesForUser(username));
// if ( currentUserSecurityGroup <= SecurityGroup.SeniorManager )
   // do stuff

namespace Api.Constants
{
    public enum AccessLevel
    {
        Support, // Suporte
        Manager, // Gerente
        SeniorManager, // Gerente Sênior
        DepartamentHead, // Chefe de Departamento
        Employee, // Funcionário
    }
}