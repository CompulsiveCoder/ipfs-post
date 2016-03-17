BRANCH=$1

if [ -z "$BRANCH" ]; then
    BRANCH=$(git branch | sed -n -e 's/^\* \(.*\)/\1/p')
fi

if [ -z "$BRANCH" ]; then
    BRANCH="master"
fi

echo "Branch: $BRANCH"

git clone https://github.com/CompulsiveCoder/ipfs-post.git --recursive --branch $BRANCH
cd ipfs-post

#git submodule update --init --recursive

sh init-build-run.sh
