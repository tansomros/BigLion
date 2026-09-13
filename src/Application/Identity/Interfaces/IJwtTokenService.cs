using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BigLion.Domain.Entities;

namespace BigLion.Application.Identity.Interfaces;
public interface IJwtTokenService
{
    string GenerateToken(User user);
}
