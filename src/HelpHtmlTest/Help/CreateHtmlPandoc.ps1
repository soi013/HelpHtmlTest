# Help htmlファイル生成スクリプト
# MarkdownからHTMLファイルを生成する

cd 'Help'
$sourcePath = ".\help.md"
$sourceTime = $(Get-ItemProperty $sourcePath).LastWriteTime
$targetPath = "..\Resources\help.html"
if (Test-Path $targetPath)
{
    $targetTime = $(Get-ItemProperty $targetPath).LastWriteTime
}
else
{
    $targetTime = 0
}

echo "Creation help.html: sourceTime is $sourceTime, targetTime is $targetTime"

# 生成したHTMLファイルが元のMarkdownファイルより更新日時が新しいときのみコンバートする
if ( $sourceTime -gt   $targetTime )
{
    echo "Start Create help.html"
    # Pandocを使用してMarkdownからHTMLファイルを生成する。cssなどを指定する
    & 'C:\Program Files\Pandoc\pandoc' -s ./help.md -o ../Resources/help.html --toc --template=./elegant_bootstrap_menu.html --self-contained -t html5 -c my_markdown.css
    echo "Finished Create help.html"
}

