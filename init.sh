DIR=$PWD

sudo apt-get install -y mono-runtime mono-xsp4

wget -q https://raw.githubusercontent.com/ipfs/install-go-ipfs/master/install-ipfs.sh
sudo sh install-ipfs.sh

git submodule update --init --recursive

cd mod/ipfs-echo/
sh init.sh
cd $DIR

cd lib
sh get-libs.sh
cd $DIR

