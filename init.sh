DIR=$PWD

echo "Initializing ipfs-post project"
echo "Dir: $PWD"

cd mod/ipfs-echo/
sh init.sh
cd $DIR

cd lib
sh get-libs.sh
cd $DIR
