# FERRAMENTA CLI EF CORE
cat << \EOF >> ~/.zprofile
# Add .NET Core SDK tools
export PATH="$PATH:/Users/piquiatuba/.dotnet/tools"
EOF

zsh -l

export PATH="$PATH:/Users/piquiatuba/.dotnet/tools"

# MIGRATIONS
Create Migration: `dotnet ef migrations add InitialCreate`
Migrate: `dotnet ef database update`