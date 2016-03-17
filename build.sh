echo "Starting build for ipfs-post project"
echo "Dir: $PWD"

DIR=$PWD

cd mod/ipfs-echo/
sh build.sh
cd $DIR

xbuild src/ipfs.post.sln /p:Configuration=Release
