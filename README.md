just test a minimal asp core web app in git and in heroku

or create a new repository on the command line

echo "# ouvrier" >> README.md
git init
git add README.md
git commit -m "first commit"
git remote add origin https://github.com/djm2x/ouvrier.git
git push -u origin master

…or push an existing repository from the command line

git remote add origin https://github.com/djm2x/ouvrier.git
git push -u origin master


-- for heroku
// heroku login
// git init
// heroku git:remote -a ouvrier
// git add .
// git commit -am 'better'
//heroku buildpacks:set https://github.com/jincod/dotnetcore-buildpack
//heroku buildpacks:set jincod/dotnetcore
// git push heroku master
