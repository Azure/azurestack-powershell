# Import the Microsoft repository key
rpm --import https://packages.microsoft.com/keys/microsoft.asc
# Create local azure-cli repository information
echo "[azure-cli]
name=Azure CLI
baseurl=https://packages.microsoft.com/yumrepos/azure-cli
enabled=1
gpgcheck=1
gpgkey=https://packages.microsoft.com/keys/microsoft.asc" | tee /etc/yum.repos.d/azure-cli.repo
# Install with the yum install command
yum -y install azure-cli