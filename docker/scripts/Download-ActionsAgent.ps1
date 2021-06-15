# Change directory to the home directory.
Set-Location
# Create a folder
mkdir actions-runner && cd actions-runner
# Download the latest runner package
curl -O -L https://github.com/actions/runner/releases/download/v2.276.0/actions-runner-linux-x64-2.276.0.tar.gz
# Extract the installer
tar xzf ./actions-runner-linux-x64-2.276.0.tar.gz