BRANCH=$1

if [ -z "$BRANCH" ]; then
    BRANCH="master"
fi

echo "Branch: $BRANCH"

git clone https://github.com/CompulsiveCoder/ipfs-post.git --branch $BRANCH
cd ipfs-cs

git submodule update --init --recursive

sh init-build-test.sh
